
using MAUI_Navigation.Utilities;

namespace MAUI_Navigation.Views;

public partial class InitialPage : ContentPage
{
	public InitialPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavigationUtilities.Examine(Navigation);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushModalAsync(new AgreementPage(txtName.Text, txtLastName.Text), true);
    }
}