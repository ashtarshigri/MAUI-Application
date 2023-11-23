namespace INOVI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void OnSignup(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Signup());
        }
        private async void OnLoginPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}