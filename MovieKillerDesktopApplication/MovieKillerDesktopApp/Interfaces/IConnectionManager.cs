namespace MovieKillerDesktopApp.Interfaces
{
    public interface IConnectionManager
    {
        void StartListenning();
        void StopListenning();
        void OpenConnection();
        void AbortConnection();
        void SendData(string message);
        string ReceiveData();
        bool IsConnected();
        string ConnectedDeviceName();
    }
}
