namespace INOVI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
  
            MainPage = new AppShell();
            //MainPage = new NavigationPage(new LoginPage());
           //MainPage = new NavigationPage(new MainPage());
        }
    }
}