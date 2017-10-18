using System;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using MovieKillerMobileApp.Models;

namespace MovieKillerMobileApp
{
    public sealed partial class StartPage
    {
        public ConnectionManager ConnectionManager;
        public StartPage()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
        private async void ConnectToPC_Button_Click(object sender, RoutedEventArgs e)
        {
            await StartConnection();
        }
        private async Task StartConnection()
        {
            ConnectionManager = new ConnectionManager();
            try
            {
                await ConnectionManager.Connect("192.168.0.199", "20");
            }
            catch (Exception exception)
            {
                await ShowAlertDialog(exception);
            }
            if (ConnectionManager.DeviceIsConnected)
            {
                await ConnectionManager.Send(TbPassword.Text);
                var password = await ConnectionManager.Read();
                await ControlCorectnessOfPassword(IsPasswordCorrect(password));
            }
        }
        private static async Task ShowAlertDialog(Exception exception)
        {
            var stackPanel = new StackPanel();
            var message = new TextBlock
            {
                Text = exception.ToString(),
                TextWrapping = TextWrapping.Wrap,
            };
            var contentDialog = new ContentDialog
            {
                Title = exception.GetType().ToString(),
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                Content = stackPanel
            };
            stackPanel.Children.Add(message);
            contentDialog.PrimaryButtonText = "OK";
            contentDialog.PrimaryButtonClick += delegate
            {
                contentDialog.Hide();
            };
            await contentDialog.ShowAsync();
        }
        private static bool IsPasswordCorrect(string password)
        {
            if(password == "OK")
            {
                return true;
            }
            return false;
        }
        private async Task ControlCorectnessOfPassword(bool isPasswordCorrect)
        {
            if(isPasswordCorrect)
            {
                var dispatcher = CoreWindow.GetForCurrentThread().Dispatcher;
                await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    Frame.Navigate(typeof(MainPage), ConnectionManager);
                });
            }
            else
            {
                const string messageBoxText = "Nieprawidłowe hasło";
                await new MessageDialog(messageBoxText).ShowAsync();
            }
        }
    }
}
