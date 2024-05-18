using Microsoft.UI;
using Windows.UI;


namespace WeighingStation.Presentation;

    public sealed partial class Units : Page
	{
		public Units()
		{
			this.InitializeComponent();
            HeaderComponent.LogoutRequested += HeaderComponent_LogoutRequested;
            SidenavComponent.NavigationRequested += SidenavComponent_NavigationRequested;
        }

        private void HeaderComponent_LogoutRequested(object sender, EventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void SidenavComponent_NavigationRequested(object sender, Type e)
        {
            Frame.Navigate(e);
        }

        private void LB_Button_Click(object sender, RoutedEventArgs e)
        {
            LB_Button.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xF3, 0xB2, 0x01));
            KG_Button.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void KG_Button_Click(object sender, RoutedEventArgs e)
        {
            KG_Button.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xF3, 0xB2, 0x01));
            LB_Button.Background = new SolidColorBrush(Colors.Transparent);
        }
}
