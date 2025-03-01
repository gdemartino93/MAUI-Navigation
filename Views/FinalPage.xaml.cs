namespace MAUI_Navigation.Views;

public partial class FinalPage : ContentPage
{
	public FinalPage()
	{
		InitializeComponent();
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