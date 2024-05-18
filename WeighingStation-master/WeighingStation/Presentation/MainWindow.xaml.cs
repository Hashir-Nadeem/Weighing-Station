using System;

namespace WeighingStation.Presentation;
public sealed partial class MainWindow : Page
{
    public MainWindow()
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

    private void NumberButton_Click(object sender, RoutedEventArgs e) {
        Button button = (Button)sender;
        InputTextBlock.Text += button.Content.ToString();
    }

    private void DotButton_Click(object sender, RoutedEventArgs e) {
        Button button = (Button)sender;

        if (InputTextBlock.Text.Length == 0) {
            InputTextBlock.Text += "0" + button.Content.ToString();
        } else if (!InputTextBlock.Text.Contains(".")) {
            InputTextBlock.Text += button.Content.ToString();
        }
    }

    private void BackspaceButton_Click(object sender, RoutedEventArgs e) {
        if (InputTextBlock.Text.Equals("0.")) {
            InputTextBlock.Text = ""; // Clear the text
        } else if (InputTextBlock.Text.Length > 0) {
            InputTextBlock.Text = InputTextBlock.Text.Substring(0, InputTextBlock.Text.Length - 1);
        }
    }
}

internal partial class MainWindowModel : ObservableObject
{
    [ObservableProperty]
    private int _count = 0;

    [ObservableProperty]
    private int _step = 1;

    [RelayCommand]
    private void Increment()
        => Count += Step;

    [RelayCommand]
    private void Decrement() {
        if (Count > 0)
            Count -= Step;
    }
}
