using System;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieKillerDesktopApp.Models;

namespace MovieKillerDesktopApp
{
    public partial class MainWindow : Form
    {
        public string PasswordToConnection { get; set; }
        public bool CheckingPasswordToConnect { get; set; }
        public bool StopTimerFromDevice { get; set; }
        public int LevelOfSpeed { get; set; }
        private readonly TcpConnectionManager deviceConnector;
        private readonly LayoutColorManager colorManager;
        private readonly AlarmClockManager alarmClockManager;
        private OperationManager.ChooseKindOfOperation kindOfOperationToDo;
        private CancellationToken cancellationToken;
        private int timeAtStart;        // nazwać inaczej 
        private int timeToStartOperation; // nazwać inaczej 
        private bool bottomPanelToHide; // nazwać inaczej 
                                        //        UINTY!!!
                                        //        isNull w ifach itd. korzystać z gotowych rozwiązań string.IsNull => {throw Exception } itd
                                        //        przenieść część funkcjonalności do klasy
                                        //        IS Activate na voidach itd.
        public MainWindow()
        {
            InitializeComponent();
            SetStartupPropertiesOfComponents();
            deviceConnector = new TcpConnectionManager(IPAddress.Any, 20);
            colorManager = new LayoutColorManager();
            alarmClockManager = new AlarmClockManager();
            kindOfOperationToDo = new OperationManager.ChooseKindOfOperation();

            Task.Factory.StartNew(ControlBottomMenu);

            LevelOfSpeed = 1000;
            bottomPanelToHide = true;

            AppDomain.CurrentDomain.ProcessExit += OnProcessExit;

            PasswordToConnection = "000"; //test
            CheckingPasswordToConnect = true;
            StopTimerFromDevice = false;
        }
        private void OnProcessExit(object sender, EventArgs e)
        {
            if(deviceConnector.IsConnected())
            {
                deviceConnector.AbortConnection();
            }
        }
        private void SetStartupPropertiesOfComponents()
        {
            rb_timeLeft.Checked = true;
            rb_lock.Checked = true;

            SetAvailabilityOfComponentsNumUd(false);
        }
        private void SetAvailabilityOfComponentsNumUd(bool availability)
        {
            if(availability)
            {
                numUD_hours.Enabled = true;
                numUD_minutes.Enabled = true;
                numUD_seconds.Enabled = true;
                numUD_inputTimeToStart.Enabled = false;
            }
            if(availability == false)
            {
                numUD_hours.Enabled = false;
                numUD_minutes.Enabled = false;
                numUD_seconds.Enabled = false;
                numUD_inputTimeToStart.Enabled = true;
            }
        }
        public void SetLayoutColor()
        {
            BackColor = colorManager.WindowBackgroundColor;

            panel_clock.BackColor = colorManager.PanelClockBackgroundColor;

            gb_operationsCollection.BackColor = colorManager.PanelOptionsBackgroundColor;
            gb_setTime.BackColor = colorManager.PanelOptionsBackgroundColor;

            lb_timer.BackColor = colorManager.LabelClockBackgroundColor;
            lb_endOfOperation.BackColor = colorManager.LabelClockBackgroundColor;

            lb_timer.ForeColor = colorManager.LabelClockForegroundColor;
            lb_endOfOperation.ForeColor = colorManager.LabelClockForegroundColor;

            rb_alarmClock.BackColor = colorManager.LabelOptionsBackgroundColor;
            rb_lock.BackColor = colorManager.LabelOptionsBackgroundColor;
            rb_logout.BackColor = colorManager.LabelOptionsBackgroundColor;
            rb_restart.BackColor = colorManager.LabelOptionsBackgroundColor;
            rb_shutDown.BackColor = colorManager.LabelOptionsBackgroundColor;
            rb_sleep.BackColor = colorManager.LabelOptionsBackgroundColor;

            rb_timeLeft.BackColor = colorManager.LabelOptionsBackgroundColor;
            rb_atTime.BackColor = colorManager.LabelOptionsBackgroundColor;

            rb_alarmClock.ForeColor = colorManager.LabelOptionsForegroundColor;
            rb_lock.ForeColor = colorManager.LabelOptionsForegroundColor;
            rb_logout.ForeColor = colorManager.LabelOptionsForegroundColor;
            rb_restart.ForeColor = colorManager.LabelOptionsForegroundColor;
            rb_shutDown.ForeColor = colorManager.LabelOptionsForegroundColor;
            rb_sleep.ForeColor = colorManager.LabelOptionsForegroundColor;

            rb_timeLeft.ForeColor = colorManager.LabelOptionsForegroundColor;
            rb_atTime.ForeColor = colorManager.LabelOptionsForegroundColor;

        }
        private void btn_startClock_Click(object sender, EventArgs e)
        {
            if(rb_timeLeft.Checked)
            {
                var timeToStart = int.Parse(numUD_inputTimeToStart.Text);

                timeToStartOperation = ComputeTimeToStartOperation(timeToStart);
            }
            if(rb_atTime.Checked)
            {
                timeToStartOperation = ComputeTimeToStartOperation();
            }

            ClockStart(timeToStartOperation);
        }
        private int ComputeTimeToStartOperation()
        {
            var dateOfFinish = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)numUD_hours.Value, (int)numUD_minutes.Value, (int)numUD_seconds.Value);
            var time = dateOfFinish.Subtract(DateTime.Now);
            var timeToStart = (int)time.TotalSeconds;

            if(timeToStart < 0)
            {
                dateOfFinish = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1, (int)numUD_hours.Value, (int)numUD_minutes.Value, (int)numUD_seconds.Value);

                time = dateOfFinish.Subtract(DateTime.Now);
                timeToStart = (int)time.TotalSeconds;
            }

            return timeToStart;
        }
        private static int ComputeTimeToStartOperation(int timeToStart)
        {
            const int secondsInMinute = 60;
            timeToStart *= secondsInMinute;
            return timeToStart;
        }
        private void ClockStart(int timeToEnd)
        {
            progressBar_TimeToEnd.Invoke(new Action(delegate
            {
                progressBar_TimeToEnd.Value = 0;
            }));

            if(timeToEnd >= 0)
            {
                timeAtStart = timeToEnd;

                BeginInvoke(new Action(delegate
                {
                    timer_clock.Start();
                }));
            }
            else
            {
                timer_clock.Stop();
                MessageBox.Show(@"Błąd danych - czas pozostały do wykonania operacji nie może być ujemny");
            }
        }
        private void timer_clock_Tick(object sender, EventArgs e)
        {
            SetSpeedOfOperation(LevelOfSpeed);

            if(timeToStartOperation == 0)
            {
                StartOperation(kindOfOperationToDo);
                ResetClock();
                timer_clock.Enabled = false;
                if(kindOfOperationToDo == OperationManager.ChooseKindOfOperation.Alarm)
                {
                    StopAlarmClock();
                }
                return;
            }
            timeToStartOperation--;

            UpdateClock(LevelOfSpeed);
        }
        private void StartOperation(OperationManager.ChooseKindOfOperation operationToDo)
        {
            var operationManager = new OperationManager(alarmClockManager);
            operationManager.StartOperation(operationToDo);
        }
        private void UpdateClock(int speed)
        {
            var timerManager = new AppTimerManager(timeToStartOperation, timeAtStart);

            lb_timer.Text = timerManager.ShowTimeToEnd();
            lb_endOfOperation.Text = timerManager.ShowTimeEndOfOperation(speed);
            progressBar_TimeToEnd.Maximum = timerManager.GetMaxValueOfprogressBar_TimeToStart();
            progressBar_TimeToEnd.Value = timerManager.GetValueOfprogressBar_TimeToStart();
        }
        private void ResetClock()
        {
            timeToStartOperation = 0;
            timeAtStart = 0;

            var timerManager = new AppTimerManager(timeToStartOperation, timeAtStart);

            lb_timer.Text = timerManager.ShowTimeToEnd();
            lb_endOfOperation.Text = @"00:00:00";
            progressBar_TimeToEnd.Maximum = timerManager.GetMaxValueOfprogressBar_TimeToStart();
            progressBar_TimeToEnd.Value = timerManager.GetValueOfprogressBar_TimeToStart();
        }
        private void StopAlarmClock()
        {
            DialogResult result1 = MessageBox.Show("Wyłącz alarm",
                "Komunikat",
                MessageBoxButtons.OK,
                MessageBoxIcon.Stop);
            if(result1 == DialogResult.OK)
            {
                StartOperation(OperationManager.ChooseKindOfOperation.StopAlarmClock);
            }
        }
        private void cbListenningConnection_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_listenningConnection.Checked)
            {
                cancellationToken = new CancellationToken();
                new Task(InteractWithDevice, cancellationToken, TaskCreationOptions.PreferFairness).Start();

                cb_listenningConnection.BackColor = Color.Green;
            }
            else if(cb_listenningConnection.Checked == false)
            {
                var cancellationTokenSource = new CancellationTokenSource();
                cancellationToken = cancellationTokenSource.Token;
                cancellationTokenSource.Cancel();

                if(deviceConnector.IsConnected())
                {
                    deviceConnector.AbortConnection();
                    ShowConnectedDevice(deviceConnector);
                    LabelMessageReceivedText("Brak połączonego kontrolera");
                }
                else
                {
                    deviceConnector.StopListenning();
                }
                cb_listenningConnection.BackColor = Color.Tomato;
            }
        }
        private void InteractWithDevice()
        {
            StopTimerFromDevice = false;

            while(!cancellationToken.IsCancellationRequested)
            {
                if(deviceConnector.IsConnected() == false && cancellationToken.IsCancellationRequested == false)
                {
                    LabelMessageReceivedText("Brak połączonego kontrolera");
                    LabelConnectionStatusText("Oczekuje na połączenie");
                    ConnectToDevice(deviceConnector);
                }
                else
                {
                    RespondOnCommandFromDevice(deviceConnector, PasswordToConnection);
                }
                ShowConnectedDevice(deviceConnector);
            }
        }
        private void ConnectToDevice(TcpConnectionManager connectionManager)
        {
            connectionManager.StartListenning();
            connectionManager.OpenConnection();

            if(connectionManager.IsConnected() && ControlConnectionAccesibility(connectionManager) == false)
            {
                connectionManager.AbortConnection();
            }
        }
        private bool ControlConnectionAccesibility(TcpConnectionManager connectionManager)
        {
            if(CheckingPasswordToConnect)
            {
                var passwordToConnect = connectionManager.ReceiveData();

                return IsPasswordFromDeviceOk(connectionManager, passwordToConnect);
            }
            return true;
        }
        private bool IsPasswordFromDeviceOk(TcpConnectionManager connectionManager, string passwordToConnectionFromDevice)
        {
            if(PasswordToConnection != passwordToConnectionFromDevice)
            {
                connectionManager.SendData("Wrong");
                WrongPasswordShowMessage(); //nie podoba mi się miejsce tej fukcji     
                LabelMessageReceivedText("Błędne hasło");
                return false;
            }
            connectionManager.SendData("OK");
            LabelMessageReceivedText("Oczekuje na polecenie");
            return true;
        }
        private static void WrongPasswordShowMessage()
        {
            MessageBox.Show(string.Format(
                "Próba połączenia się z aplikacją przez urządzenie mobilne{0}" +
                "została odrzucona - błędne hasło", Environment.NewLine));
        }
        private void RespondOnCommandFromDevice(TcpConnectionManager connectionManager, string passwordToConnection)
        {
            var dataDecoder = new ReceivedDataDecoder();
            var currentData = connectionManager.ReceiveData();

            if(currentData == "Disconnected" || currentData == "Błąd wiadomości" || currentData == passwordToConnection)
            {
                return;
            }
            if(currentData == "Koniec")
            {
                connectionManager.AbortConnection();
            }

            var currentCommand = dataDecoder.DecodeMessage("Command", currentData);

            SetOperationToDo(currentCommand);
            LabelMessageReceivedText(dataDecoder.DecodeCommand(currentCommand));

            if(currentCommand != "Speed")
            {
                try
                {
                    timeToStartOperation =
                        ComputeTimeToStartOperation(int.Parse(dataDecoder.DecodeMessage("Time", currentData)));
                    LevelOfSpeed = 1000;
                    ClockStart(timeToStartOperation);
                }
                catch(Exception e)
                {
                    if(e is FormatException)
                    {
                        MessageBox.Show("Nieprawidłowy format wiadomości");
                    }
                    else
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
            }
            else
            {
                LevelOfSpeed = int.Parse(dataDecoder.DecodeMessage("Speed", currentData));
            }
        }
        private void SetOperationToDo(string currentCommand) //może chooseKindOfOperation  dodać + sprawdzić czy reaguje na zmiany operacji
        {
            switch(currentCommand)
            {
                case "U":
                    kindOfOperationToDo = OperationManager.ChooseKindOfOperation.Sleep;
                    break;
                case "W":
                    kindOfOperationToDo = OperationManager.ChooseKindOfOperation.Shutdown;
                    break;
                case "R":
                    kindOfOperationToDo = OperationManager.ChooseKindOfOperation.Restart;
                    break;
                case "L":
                    kindOfOperationToDo = OperationManager.ChooseKindOfOperation.Lock;
                    break;
                case "LO":
                    kindOfOperationToDo = OperationManager.ChooseKindOfOperation.LogOut;
                    break;
                case "Budzik":
                    kindOfOperationToDo = OperationManager.ChooseKindOfOperation.Alarm;
                    break;
                case "Stop":
                    kindOfOperationToDo = OperationManager.ChooseKindOfOperation.StopTimerFromDevice;
                    break;
                case "Speed":
                    kindOfOperationToDo = OperationManager.ChooseKindOfOperation.SetLevelOfSpeed;
                    break;
            }
        }
        private void ShowConnectedDevice(TcpConnectionManager connectionManager)
        {
            if(connectionManager.IsConnected())
            {
                LabelConnectionStatusText("Połączono z: " + connectionManager.ConnectedDeviceName());
            }
            else if(connectionManager.IsConnected() == false)
            {
                LabelConnectionStatusText("Brak połączenia");
            }
        }
        private void cb_pauseClock_CheckedChanged(object sender, EventArgs e)
        {
            PauseClock();
        }
        private void PauseClock()
        {
            timer_clock.Enabled = cb_pauseClock.Checked != true;
        }
        private void btn_slowDownCountdown_Click(object sender, EventArgs e)
        {
            LevelOfSpeed += 200;
        }
        private void btn_speedUpCountdown_Click(object sender, EventArgs e)
        {
            if(LevelOfSpeed > 200)
            {
                LevelOfSpeed -= 200;
            }
        }
        private void SetSpeedOfOperation(int speed)
        {
            if(speed > 0)
            {
                timer_clock.Interval = speed;
            }
        }
        private void panel_bottomMenu_MouseEnter(object sender, EventArgs e)
        {
            bottomPanelToHide = false;
        }
        private void panel_bottomMenu_MouseLeave(object sender, EventArgs e)
        {
            bottomPanelToHide = true;
        }
        private void lb_messageReceived_Click(object sender, EventArgs e)
        {

        }
        private void btn_stopClock_Click(object sender, EventArgs e)
        {
            timer_clock.Enabled = false;
            ResetClock();
        }
        private void btn_settings_Click(object sender, EventArgs e)
        {
            new SettingsWindow(colorManager, alarmClockManager).Show();
        }
        private void lb_connectionStatus_Click(object sender, EventArgs e)
        {

        }
        private void ControlBottomMenu()
        {
            while(true)
            {
                if(bottomPanelToHide && panel_bottomMenu.Height > 20)
                {
                    panel_bottomMenu.Invoke(new Action(delegate
                    {
                        panel_bottomMenu.Height--;
                    }));
                }
                if(bottomPanelToHide == false && panel_bottomMenu.Height <= 50)
                {
                    panel_bottomMenu.Invoke(new Action(delegate
                    {
                        panel_bottomMenu.Height++;
                    }));
                }
            }
        }
        private void RadioButtonChooseKindOfCountingTimeManager(object sender, EventArgs e)
        {
            if(rb_atTime.Checked)
            {
                SetAvailabilityOfComponentsNumUd(true);
            }
            if(rb_timeLeft.Checked)
            {
                SetAvailabilityOfComponentsNumUd(false);
            }
        }
        private void RadioButtonChooseKindOfOperationManager(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            if(radioButton != null && radioButton.Checked)
            {
                var operation = "";
                switch(radioButton.Name)
                {
                    case "rb_lock":
                        operation = "L";
                        break;
                    case "rb_logout":
                        operation = "LO";
                        break;
                    case "rb_restart":
                        operation = "R";
                        break;
                    case "rb_shutDown":
                        operation = "W";
                        break;
                    case "rb_sleep":
                        operation = "U";
                        break;
                    case "rb_alarmClock":
                        operation = "Budzik";
                        break;
                }
                SetOperationToDo(operation);
            }

        }
        private void LabelConnectionStatusText(string message)
        {
            lb_connectionStatus.Invoke(new Action(delegate
            {
                lb_connectionStatus.Text = string.Format("Status połączenia:{0}{1}", Environment.NewLine, message);
            }));
        }
        private void LabelMessageReceivedText(string message)
        {
            lb_messageReceived.Invoke(new Action(delegate
            {
                lb_messageReceived.Visible = true;
                lb_messageReceived.Text = string.Format("Użytkownik wydał komendę: {0}{1}",
                                                        Environment.NewLine, message);
            }));
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
