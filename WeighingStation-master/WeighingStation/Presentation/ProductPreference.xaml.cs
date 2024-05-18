namespace WeighingStation.Presentation;

	public sealed partial class ProductPreference : Page
	{
		public ProductPreference()
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
}
