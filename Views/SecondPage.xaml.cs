using MAUI_Navigation.Utilities;

namespace MAUI_Navigation.Views;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavigationUtilities.Examine(Navigation);
    }

    private void Button_Back_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }

    private void Button_Next_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FinalPage());
    }
}