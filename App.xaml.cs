using MAUI_Navigation.Views;

namespace MAUI_Navigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new InitialPage());
        }
    }
}
