﻿using System;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieKillerDesktopApp.Interfaces;
using MovieKillerDesktopApp.Models;

namespace MovieKillerDesktopApp
{
    public partial class MainWindow : Form
    {
        public string PasswordToOpenConnection { get; set; }
        public bool IsCheckingPasswordAvaible { get; set; }
        public bool IsTimerStoppedByDevice { get; set; }
        public int LevelOfClockTickingSpeed { get; set; }
        private readonly TcpConnectionManager deviceConnector;
        private readonly LayoutColorManager layoutColorManager;
        private readonly AlarmClockManager alarmClockManager;
        private OperationManager.ChooseKindOfOperation kindOfOperationToDo;
        private CancellationToken cancellationToken;
        private int premierTimeToStartOperation;
        private int actualTimeToStartOperation;
        private bool isBottomMenuHidden;

        public MainWindow()
        {
            InitializeComponent();
            SetStartupPropertiesOfComponents();
            deviceConnector = new TcpConnectionManager(IPAddress.Any, 20);
            layoutColorManager = new LayoutColorManager();
            alarmClockManager = new AlarmClockManager();
            kindOfOperationToDo = new OperationManager.ChooseKindOfOperation();

            Task.Factory.StartNew(ControlPositionOfBottomMenu);

            LevelOfClockTickingSpeed = 1000;
            isBottomMenuHidden = true;

            AppDomain.CurrentDomain.ProcessExit += OnProcessExit;

            PasswordToOpenConnection = "000"; //test
            IsCheckingPasswordAvaible = true;
            IsTimerStoppedByDevice = false;
        }
        private void OnProcessExit(object sender, EventArgs e)
        {
            if(deviceConnector.IsConnected())
            {
                deviceConnector.AbortConnection();
            }
        }
        #region InitialSettingsOfMainWindow
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
            else
            {
                numUD_hours.Enabled = false;
                numUD_minutes.Enabled = false;
                numUD_seconds.Enabled = false;
                numUD_inputTimeToStart.Enabled = true;
            }
        }
        public void SetLayoutColor()
        {
            BackColor = layoutColorManager.WindowBackgroundColor;

            panel_clock.BackColor = layoutColorManager.PanelClockBackgroundColor;

            gb_operationsCollection.BackColor = layoutColorManager.PanelOptionsBackgroundColor;
            gb_setTime.BackColor = layoutColorManager.PanelOptionsBackgroundColor;

            lb_timer.BackColor = layoutColorManager.LabelClockBackgroundColor;
            lb_endOfOperation.BackColor = layoutColorManager.LabelClockBackgroundColor;

            lb_timer.ForeColor = layoutColorManager.LabelClockForegroundColor;
            lb_endOfOperation.ForeColor = layoutColorManager.LabelClockForegroundColor;

            rb_alarmClock.BackColor = layoutColorManager.LabelOptionsBackgroundColor;
            rb_lock.BackColor = layoutColorManager.LabelOptionsBackgroundColor;
            rb_logout.BackColor = layoutColorManager.LabelOptionsBackgroundColor;
            rb_restart.BackColor = layoutColorManager.LabelOptionsBackgroundColor;
            rb_shutDown.BackColor = layoutColorManager.LabelOptionsBackgroundColor;
            rb_sleep.BackColor = layoutColorManager.LabelOptionsBackgroundColor;

            rb_timeLeft.BackColor = layoutColorManager.LabelOptionsBackgroundColor;
            rb_atTime.BackColor = layoutColorManager.LabelOptionsBackgroundColor;

            rb_alarmClock.ForeColor = layoutColorManager.LabelOptionsForegroundColor;
            rb_lock.ForeColor = layoutColorManager.LabelOptionsForegroundColor;
            rb_logout.ForeColor = layoutColorManager.LabelOptionsForegroundColor;
            rb_restart.ForeColor = layoutColorManager.LabelOptionsForegroundColor;
            rb_shutDown.ForeColor = layoutColorManager.LabelOptionsForegroundColor;
            rb_sleep.ForeColor = layoutColorManager.LabelOptionsForegroundColor;

            rb_timeLeft.ForeColor = layoutColorManager.LabelOptionsForegroundColor;
            rb_atTime.ForeColor = layoutColorManager.LabelOptionsForegroundColor;
        }
        #endregion
        #region OnClockOperations
        private void btn_startClock_Click(object sender, EventArgs e)
        {
            PrepareClockToStart();
            ClockStart(actualTimeToStartOperation);
        }
        private void PrepareClockToStart()
        {
            if(rb_timeLeft.Checked)
            {
                var timeToStart = int.Parse(numUD_inputTimeToStart.Text);
                actualTimeToStartOperation = ComputeTimeToStartOperation(timeToStart);
            }
            if(rb_atTime.Checked)
            {
                var dateOfFinishOperation = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                    (int)numUD_hours.Value, (int)numUD_minutes.Value, (int)numUD_seconds.Value);
                actualTimeToStartOperation = ComputeTimeToStartOperation(dateOfFinishOperation);
            }
        }
        private int ComputeTimeToStartOperation(DateTime dateTime)
        {
            var timeToStartOperation = ConvertDateTimeToTimeToStart(dateTime);
            return timeToStartOperation;
        }
        private int ConvertDateTimeToTimeToStart(DateTime dateTime)
        {
            var time = dateTime.Subtract(DateTime.Now);
            var timeToStartOperation = (int)time.TotalSeconds;

            if(timeToStartOperation < 0)
            {
                dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1,
                                            (int)numUD_hours.Value, (int)numUD_minutes.Value, (int)numUD_seconds.Value);
                time = dateTime.Subtract(DateTime.Now);
                timeToStartOperation = (int)time.TotalSeconds;
            }
            return timeToStartOperation;
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
                premierTimeToStartOperation = timeToEnd;

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
            SetSpeedOfOperation(LevelOfClockTickingSpeed);

            if(actualTimeToStartOperation == 0)
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
            actualTimeToStartOperation--;

            UpdateClock(LevelOfClockTickingSpeed);
        }
        private void UpdateClock(int speed)
        {
            var timerManager = new AppTimerManager(actualTimeToStartOperation, premierTimeToStartOperation);

            lb_timer.Text = timerManager.ShowTimeToEnd();
            lb_endOfOperation.Text = timerManager.ShowTimeEndOfOperation(speed);
            progressBar_TimeToEnd.Maximum = timerManager.GetMaxValueOfprogressBar_TimeToStart();
            progressBar_TimeToEnd.Value = timerManager.GetValueOfprogressBar_TimeToStart();
        }
        private void ResetClock()
        {
            actualTimeToStartOperation = 0;
            premierTimeToStartOperation = 0;

            var timerManager = new AppTimerManager(actualTimeToStartOperation, premierTimeToStartOperation);

            lb_timer.Text = timerManager.ShowTimeToEnd();
            lb_endOfOperation.Text = @"00:00:00";
            progressBar_TimeToEnd.Maximum = timerManager.GetMaxValueOfprogressBar_TimeToStart();
            progressBar_TimeToEnd.Value = timerManager.GetValueOfprogressBar_TimeToStart();
        }
        private void StopAlarmClock()
        {
            DialogResult result1 = MessageBox.Show(@"Wyłącz alarm",
                @"Komunikat",
                MessageBoxButtons.OK,
                MessageBoxIcon.Stop);
            if(result1 == DialogResult.OK)
            {
                StartOperation(OperationManager.ChooseKindOfOperation.StopAlarmClock);
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
        private void btn_stopClock_Click(object sender, EventArgs e)
        {
            timer_clock.Enabled = false;
            ResetClock();
        }
        private void btn_slowDownCountdown_Click(object sender, EventArgs e)
        {
            LevelOfClockTickingSpeed += 200;
        }
        private void btn_speedUpCountdown_Click(object sender, EventArgs e)
        {
            if(LevelOfClockTickingSpeed > 200)
            {
                LevelOfClockTickingSpeed -= 200;
            }
        }
        private void SetSpeedOfOperation(int speed)
        {
            if(speed > 0)
            {
                timer_clock.Interval = speed;
            }
        }
        #endregion
        #region SystemOperations
        private void StartOperation(OperationManager.ChooseKindOfOperation operationToDo)
        {
            var operationManager = new OperationManager(alarmClockManager);
            operationManager.StartOperation(operationToDo);
        }
        #endregion
        #region DeviceConnectionSettings
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
            IsTimerStoppedByDevice = false;

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
                    RespondOnCommandFromDevice(deviceConnector, PasswordToOpenConnection);
                }
                ShowConnectedDevice(deviceConnector);
            }
        }
        private void ConnectToDevice(IConnectionManager connectionManager)
        {
            connectionManager.StartListenning();
            connectionManager.OpenConnection();

            if(connectionManager.IsConnected() && ControlConnectionAccesibility(connectionManager) == false)
            {
                connectionManager.AbortConnection();
            }
        }
        private bool ControlConnectionAccesibility(IConnectionManager connectionManager)
        {
            if(IsCheckingPasswordAvaible)
            {
                var passwordToConnect = connectionManager.ReceiveData();

                return IsPasswordFromDeviceOk(connectionManager, passwordToConnect);
            }
            return true;
        }
        private bool IsPasswordFromDeviceOk(IConnectionManager connectionManager, string passwordToConnectionFromDevice)
        {
            if(PasswordToOpenConnection != passwordToConnectionFromDevice)
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
        private void RespondOnCommandFromDevice(IConnectionManager connectionManager, string passwordToConnection)
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
                    actualTimeToStartOperation =
                        ComputeTimeToStartOperation(int.Parse(dataDecoder.DecodeMessage("Time", currentData)));
                    LevelOfClockTickingSpeed = 1000;
                    ClockStart(actualTimeToStartOperation);
                }
                catch(Exception e)
                {
                    if(e is FormatException)
                    {
                        MessageBox.Show(@"Nieprawidłowy format wiadomości");
                    }
                    else
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
            }
            else
            {
                LevelOfClockTickingSpeed = int.Parse(dataDecoder.DecodeMessage("Speed", currentData));
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
        private void ShowConnectedDevice(IConnectionManager connectionManager)
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
        #endregion
        #region BottomMenuSettings
        private void panel_bottomMenu_MouseEnter(object sender, EventArgs e)
        {
            isBottomMenuHidden = false;
        }
        private void panel_bottomMenu_MouseLeave(object sender, EventArgs e)
        {
            isBottomMenuHidden = true;
        }
        private Task ControlPositionOfBottomMenu()
        {
            while(true)
            {
                if(isBottomMenuHidden && panel_bottomMenu.Height > 20)
                {
                    panel_bottomMenu.Invoke(new Action(delegate
                    {
                        panel_bottomMenu.Height--;
                    }));
                }
                if(isBottomMenuHidden == false && panel_bottomMenu.Height <= 50)
                {
                    panel_bottomMenu.Invoke(new Action(delegate
                    {
                        panel_bottomMenu.Height++;
                    }));
                }
            }
        }
        #endregion
        #region ComponentsSettings
        private void btn_settings_Click(object sender, EventArgs e)
        {
            new SettingsWindow(layoutColorManager, alarmClockManager).Show();
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
                var operation = string.Empty;
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
                lb_connectionStatus.Text = $@"Status połączenia:{Environment.NewLine}{message}";
            }));
        }
        private void LabelMessageReceivedText(string message)
        {
            lb_messageReceived.Invoke(new Action(delegate
            {
                lb_messageReceived.Visible = true;
                lb_messageReceived.Text = $@"Użytkownik wydał komendę: {Environment.NewLine}{message}";
            }));
        }
        #endregion
    }
}
