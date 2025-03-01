using MAUI_Navigation.Utilities;

namespace MAUI_Navigation.Views;

public partial class FinalPage : ContentPage
{
	public FinalPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavigationUtilities.Examine(Navigation);
    }

    private void Button_Previous_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void Button_Home_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}