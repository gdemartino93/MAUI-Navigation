using MAUI_Navigation.Utilities;

namespace MAUI_Navigation.Views;

public partial class AgreementPage : ContentPage
{
    private string userName;
    private string userLastName;
	public AgreementPage()
	{
		InitializeComponent();
	}
    public AgreementPage(string name, string lastName)
    {
        InitializeComponent();
        userName = name;
        userLastName = lastName;
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
		Navigation.PopModalAsync(true);
        //NavigationUtilities.RemovePage(Navigation, new InitialPage().GetType().Name);
        Application.Current.MainPage = new NavigationPage(new HomePage(userName, userLastName));
    }
}