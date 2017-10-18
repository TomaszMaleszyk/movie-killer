using System;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using MovieKillerMobileApp.Models;

namespace MovieKillerMobileApp
{
    public sealed partial class MainPage
    {
        private ConnectionManager connectionManager;
        private DispatcherTimer timer;
        private string commandToSend;
        private int timeToStartOperation;
        private int timeAtStart;
        private int secondsToStartOperation;
        private int levelOfSpeed;
        private bool accessToSendCommand;
        private bool isOperationStarted;
        public MainPage()
        {
            InitializeComponent();
            Windows.Phone.UI.Input.HardwareButtons.BackPressed += HardwareButtons_BackPressed;
            NavigationCacheMode = NavigationCacheMode.Required;
            CreateNewDispatcher();
            accessToSendCommand = false;
            isOperationStarted = false;
            levelOfSpeed = 1000;
        }
        private void CreateNewDispatcher()
        {
            timer = new DispatcherTimer();
            timer.Tick += timer_Tick;
            timer.Interval = new TimeSpan(00, 0, 1);
        }
        private void timer_Tick(object sender, object e)
        {
            UpdateClock();
            ControlStatusOfConnection();
        }
        private void UpdateClock()
        {
            if(timeToStartOperation > 0)
            {
                secondsToStartOperation--;
            }
            else
            {
                timer.Stop();
            }
            var timerManager = new AppTimerManager(secondsToStartOperation, timeAtStart);
            TxtClock.Text = timerManager.ShowTimeToEnd();
            ProgressBarTimeToEnd.Maximum = timerManager.GetMaxValueOfprogressBar_TimeToStart();
            ProgressBarTimeToEnd.Value = timerManager.GetValueOfprogressBar_TimeToStart();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            connectionManager = e.Parameter as ConnectionManager;
            ControlStatusOfConnection();
        }
        private void ControlStatusOfConnection()
        {
            var bi = new BitmapImage();

            if(connectionManager.DeviceIsConnected)
            {
                bi.UriSource = new Uri("ms-appx:///Assets/on.png");
                ImageConnectionStatus.Source = bi;
            }
            else
            {
                bi.UriSource = new Uri("ms-appx:///Assets/on.png");
                ImageConnectionStatus.Source = bi;
            }
        }
        private async void SendCommand_ButtonClick(object sender, RoutedEventArgs e)
        {
            await ShowInputTimeToEndDialog(sender);
            await SendCommand(sender);
        }
        private async Task ShowInputTimeToEndDialog(object sender)
        {
            var button = sender as Button;
            var contentDialog = CreateContentDialog();
            var stackPanel = CreateStackPanel();
            var textBoxInputTimeToStartOperation = CreateTextBox();

            contentDialog.Content = stackPanel;
            stackPanel.Children.Add(textBoxInputTimeToStartOperation);

            contentDialog.PrimaryButtonText = "Zatwierdź";
            contentDialog.PrimaryButtonClick += delegate
            {
                if(button != null)
                {
                    accessToSendCommand = true;
                    timeToStartOperation = int.Parse(textBoxInputTimeToStartOperation.Text);
                    timer.Start();
                }
            };

            contentDialog.SecondaryButtonText = "Anuluj";
            contentDialog.SecondaryButtonClick += delegate
            {
                if(button != null)
                {
                    accessToSendCommand = false;
                    contentDialog.Hide();
                }
            };

            await contentDialog.ShowAsync();
        }
        private static StackPanel CreateStackPanel()
        {
            var stackPanel = new StackPanel();
            return stackPanel;
        }
        private ContentDialog CreateContentDialog()
        {
            var contentDialog = new ContentDialog
            {
                Title = "Proszę podać czas pozostały do wykonania operacji (min)",
                MaxWidth = ActualWidth,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
            };
            return contentDialog;
        }
        private static TextBox CreateTextBox()
        {
            var textBoxInputTimeToStartOperation = new TextBox
            {
                Text = "00000000",
                TextWrapping = TextWrapping.Wrap,
                InputScope = new InputScope
                {
                    Names = { new InputScopeName { NameValue = InputScopeNameValue.Number } }
                }
            };
            return textBoxInputTimeToStartOperation;
        }
        private async Task SendCommand(object sender)
        {
            if (connectionManager.DeviceIsConnected && accessToSendCommand)
            {
                var commandName = ((Button) sender).Content?.ToString();
                switch (commandName)
                {
                    case "Uśpij":
                        commandToSend = "U,";
                        break;
                    case "Wyłącz":
                        commandToSend = "W,";
                        break;
                    case "Zrestartuj":
                        commandToSend = "R,";
                        break;
                    case "Zablokuj":
                        commandToSend = "L,";
                        break;
                    case "Wyloguj":
                        commandToSend = "LO,";
                        break;
                    case "Budzik":
                        commandToSend = "Budzik,";
                        break;
                }
                await connectionManager.Send(commandToSend + timeToStartOperation);
                isOperationStarted = true;
                secondsToStartOperation = ConvertMinutesToSeconds(timeToStartOperation);
                timeAtStart = secondsToStartOperation;
            }
        }
        private async void ManageTime_ButtonClick(object sender, RoutedEventArgs e)
        {
            await ManageManipulatingTime(sender);
        }
        private async Task ManageManipulatingTime(object sender)
        {
            if(connectionManager.DeviceIsConnected && isOperationStarted)
            {
                var commandName = ((Button) sender).Content?.ToString();
                switch(commandName)
                {
                    case "+":
                        timeToStartOperation++;
                        break;
                    case "-":
                        timeToStartOperation--;
                        break;
                }
                await connectionManager.Send(commandToSend + timeToStartOperation);

                secondsToStartOperation = ConvertMinutesToSeconds(timeToStartOperation);
                timeAtStart = secondsToStartOperation;
            }
        }
        private async void ManageSpeed_ButtonClick(object sender, RoutedEventArgs e)
        {
            await ManageManipulatingOfSpeed(sender);
        }
        private async Task ManageManipulatingOfSpeed(object sender)
        {
            if(connectionManager.DeviceIsConnected && isOperationStarted)
            {
                var commandName = ((Button) sender).Content?.ToString();
                switch(commandName)
                {
                    case "+":
                        levelOfSpeed -= 200;
                        break;
                    case "-":
                        if(levelOfSpeed > 200)
                        {
                            levelOfSpeed += 200;
                        }
                        break;
                }
                await connectionManager.Send("Speed," + levelOfSpeed);

                secondsToStartOperation = ConvertMinutesToSeconds(timeToStartOperation);
                timeAtStart = secondsToStartOperation;
            }
        }
        private static int ConvertMinutesToSeconds(int minutes)
        {
            const int secondsInMinute = 60;
            return minutes * secondsInMinute;
        }
        private async void BtnStopRunningOperation_Click(object sender, RoutedEventArgs e)
        {
            await SendCommandToStopOperation();
        }
        private async Task SendCommandToStopOperation()
        {
            if(connectionManager.DeviceIsConnected && isOperationStarted)
            {
                commandToSend = "Stop,";
                timeToStartOperation = 0;
                await connectionManager.Send(commandToSend + timeToStartOperation);
                secondsToStartOperation = ConvertMinutesToSeconds(timeToStartOperation);
                timeAtStart = secondsToStartOperation;
            }
        }
        private void HardwareButtons_BackPressed(object sender, Windows.Phone.UI.Input.BackPressedEventArgs e)
        {
            if(!e.Handled && Frame.CurrentSourcePageType.FullName == "TcpClientWP.MainPage")
            {
                connectionManager?.Send("Koniec");
                Application.Current.Exit();
            }
        }
    }
}

