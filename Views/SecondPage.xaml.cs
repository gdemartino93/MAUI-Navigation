namespace MAUI_Navigation.Views;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
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