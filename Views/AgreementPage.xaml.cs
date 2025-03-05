namespace MAUI_Navigation.Views;

public partial class AgreementPage : ContentPage
{
	public AgreementPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked_Accept(object sender, EventArgs e)
    {
		Navigation.PopModalAsync(true);
    }
}