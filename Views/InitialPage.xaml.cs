
using MAUI_Navigation.Utilities;
using MAUI_Navigation.ViewModels;

namespace MAUI_Navigation.Views;

public partial class InitialPage : ContentPage
{
	public InitialPage()
	{
		InitializeComponent();
        BindingContext = new InitialPageViewModel();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavigationUtilities.Examine(Navigation);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var currentContext = (InitialPageViewModel)BindingContext;
        Navigation.PushModalAsync(new AgreementPage
        {
            BindingContext = new AgreementPageViewModel
            {
                Name = currentContext.Name,
                LastName = currentContext.LastName
            }
        });
    }
}