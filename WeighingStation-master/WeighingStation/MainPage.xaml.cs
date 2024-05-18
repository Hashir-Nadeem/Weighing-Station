namespace WeighingStation
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void CreateAccount_Button(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Presentation.SignUpPage));
        }

        private void MainWindow_Button(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Presentation.MainWindow));
        }
    }
}
