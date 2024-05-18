namespace WeighingStation.XamlControlLibrary
{
    public sealed partial class Header : Page
    {
        public event EventHandler LogoutRequested;

        public Header()
        {
            this.InitializeComponent();
        }

        public static readonly DependencyProperty HeaderTextProperty =
            DependencyProperty.Register("HeaderText", typeof(string), typeof(Header), new PropertyMetadata("Weighing Station"));

        public string HeaderText
        {
            get { return (string)GetValue(HeaderTextProperty); }
            set { SetValue(HeaderTextProperty, value); }
        }

        private async void Button_Click3(object sender, RoutedEventArgs e)
        {
            var contentDialog = new ContentDialog()
            {
                Title = "Log out",
                Content = "Are you sure you want to log out?",
                PrimaryButtonText = "Log out",
                CloseButtonText = "Cancel",
                DefaultButton = ContentDialogButton.Primary,
                XamlRoot = this.XamlRoot,
            };

            if (await contentDialog.ShowAsync() == ContentDialogResult.Primary)
            {
                LogoutRequested?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
