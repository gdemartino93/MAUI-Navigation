using MAUI_Navigation.Utilities;
using MAUI_Navigation.ViewModels;

namespace MAUI_Navigation.Views;

public partial class AgreementPage : ContentPage
{
	public AgreementPage()
	{
		InitializeComponent();
	}

    #region Event Override
    protected override bool OnBackButtonPressed()
    {
        return true;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavigationUtilities.Examine(Navigation);
    }
    #endregion
    private void Button_Clicked_Accept(object sender, EventArgs e)
    {
        var currentBinding = (AgreementPageViewModel)BindingContext;
		Navigation.PopModalAsync(true);
        //NavigationUtilities.RemovePage(Navigation, new InitialPage().GetType().Name);
        Application.Current.MainPage = new NavigationPage(new HomePage
        {
            BindingContext = new HomePageViewModel
            {
                Name = currentBinding.Name,
                LastName = currentBinding.LastName
            }
        });
    }
}