using System;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;
using UnicodeEncoding = Windows.Storage.Streams.UnicodeEncoding;

namespace MovieKillerMobileApp.Models
{
    public class ConnectionManager
    {
        public bool DeviceIsConnected { get; private set; }
        private readonly StreamSocket socket;
        public ConnectionManager()
        {
            socket = new StreamSocket();
            DeviceIsConnected = false;
        }
        public void AbortConnection()
        {
            socket.Dispose();
        }
        public async Task Connect(string host, string port)
        {
            var hostName = new HostName(host);
            socket.Control.NoDelay = false;
            try
            {
                await socket.ConnectAsync(hostName, port);
                DeviceIsConnected = true;
            }
            catch(Exception exception)
            {
                switch(SocketError.GetStatus(exception.HResult))
                {
                    case SocketErrorStatus.HostNotFound:
                        throw;
                    default:
                        throw;
                }
            }
        }
        public async Task Send(string message)
        {
            using(var dataWriter = new DataWriter(socket.OutputStream))
            {
                dataWriter.UnicodeEncoding = UnicodeEncoding.Utf8;
                dataWriter.ByteOrder = ByteOrder.LittleEndian;

                dataWriter.MeasureString(message);
                dataWriter.WriteString(message);

                try
                {
                    await dataWriter.StoreAsync();
                }
                catch(Exception exception)
                {
                    switch(SocketError.GetStatus(exception.HResult))
                    {
                        case SocketErrorStatus.HostNotFound:
                            throw;
                        default:
                            throw;
                    }
                }

                await dataWriter.FlushAsync();
                dataWriter.DetachStream();
            }
        }
        public async Task<string> Read()
        {
            using(var dataReader = new DataReader(socket.InputStream))
            {
                var stringBuilder = new StringBuilder();
                
                dataReader.InputStreamOptions = InputStreamOptions.Partial;
                dataReader.UnicodeEncoding = UnicodeEncoding.Utf8;
                dataReader.ByteOrder = ByteOrder.LittleEndian;

                await dataReader.LoadAsync(12);

                while(dataReader.UnconsumedBufferLength > 0)
                {
                    stringBuilder.Append(dataReader.ReadString(dataReader.UnconsumedBufferLength));
                }

                dataReader.DetachStream();
                return stringBuilder.ToString();
            }
        }
    }
}
