using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MovieKillerDesktopApp.Models
{
    public class TcpConnectionManager : TcpListener
    {
        private readonly TcpListener tcpListener;
        private Socket serverSocket;
        private byte[] buffer;
        private new bool Active => base.Active;
        public string SocketRemoteEndpointAddress { get; private set; }

        public TcpConnectionManager(IPAddress ipAddress, int port) : base(ipAddress, port)
        {
            tcpListener = new TcpListener(ipAddress, port);
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            buffer = new byte[1024];
            SocketRemoteEndpointAddress = "No devices connected";
        }
        public void StartListenning()
        {
            if(!Active)
            {
                tcpListener.Start();
            }
        }
        public void StopListenning()
        {
            tcpListener.Stop();
        }
        public void AbortConnection()
        {
            serverSocket.Shutdown(SocketShutdown.Both);
            serverSocket.Close();
            serverSocket.Dispose();
            StopListenning();
        }
        public void OpenConnection()
        {
            try
            {
                serverSocket = tcpListener.AcceptSocket();
                SocketRemoteEndpointAddress = serverSocket.RemoteEndPoint.ToString();
            }
            catch(SocketException)
            {
                // tu sypie wyjątkami po rozłączeniu podłączonego połączenia
                if(serverSocket.Connected)
                {
                    AbortConnection();
                }
            }
        }
        public bool IsConnected()
        {
            if(serverSocket == null || serverSocket.Connected == false)
                return false;
            return true;
        }
        public string ReceiveData()
        {
            int dataToReceive;
            const int receiveTimeoutSocketExceptionErrorCode = 10060;
            var receivedData = "Błąd wiadomości";
            buffer = new byte[1024];

            serverSocket.ReceiveTimeout = 2000;

            try
            {
                dataToReceive = serverSocket.Receive(buffer);
            }
            catch(Exception e)
            {
                var socketException = e as SocketException;
                if(socketException != null && socketException.ErrorCode == receiveTimeoutSocketExceptionErrorCode)
                {
                    return ReceiveData();
                }
                return "Błąd wiadomości";
            }

            if(dataToReceive != 0)
            {
                var copyOfBuffer = new byte[dataToReceive];
                Array.Copy(buffer, copyOfBuffer, dataToReceive);
                receivedData = Encoding.ASCII.GetString(copyOfBuffer);
            }
            return receivedData;
        }
        public string ConnectedDeviceName()
        {
            return SocketRemoteEndpointAddress;
        }
        public void SendData(string message)
        {
            byte[] byData = Encoding.ASCII.GetBytes(message);
            try
            {
                serverSocket.Send(byData);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                //                throw;
            }
        }
    }
}
