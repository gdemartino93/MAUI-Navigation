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
    #endregion
    private void Button_Clicked_Accept(object sender, EventArgs e)
    {
		Navigation.PopModalAsync(true);
    }
}