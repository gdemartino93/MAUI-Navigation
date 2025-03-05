namespace MAUI_Navigation.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}
    public HomePage(string name, string lastName)
    {
        InitializeComponent();
        lblWelcome.Text = $"Benvenuto {name} {lastName}";
    }
}