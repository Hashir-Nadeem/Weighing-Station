namespace WeighingStation.Presentation;
public sealed partial class SignUpPage : Page
{
    public SignUpPage()
    {
        this.InitializeComponent();
    }

    private void CreateButton_Back(object sender, RoutedEventArgs e)
    {
        Frame.Navigate(typeof(MainPage));
    }
}
