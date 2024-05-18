namespace WeighingStation.XamlControlLibrary
{
    public sealed partial class SideNav : Page
    {
        public event EventHandler<Type> NavigationRequested;

        public SideNav()
        {
            this.InitializeComponent();
        }

        private void Home_Button(object sender, RoutedEventArgs e)
        {
            NavigationRequested?.Invoke(this, typeof(Presentation.MainWindow));
        }

        private void ProductPreference_Button(object sender, RoutedEventArgs e)
        {
            NavigationRequested?.Invoke(this, typeof(Presentation.ProductPreference));
        }

        private void RoomPreference_Button(object sender, RoutedEventArgs e)
        {
            NavigationRequested?.Invoke(this, typeof(Presentation.RoomPreference));
        }

        private void Settings_Button(object sender, RoutedEventArgs e)
        {
            NavigationRequested?.Invoke(this, typeof(Presentation.Settings));
        }

        private void Sync_Button(object sender, RoutedEventArgs e)
        {
            NavigationRequested?.Invoke(this, typeof(Presentation.Sync));
        }

        private void Units_Button(object sender, RoutedEventArgs e)
        {
            NavigationRequested?.Invoke(this, typeof(Presentation.Units));
        }
    }
}
