using INOVI.Pages;

namespace INOVI;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void Login_Clicked(object sender, EventArgs e)
    {
        //string userName = txtUserName.Text;
        //string password = txtPassword.Text;
        //if (userName == null || password == null)
        //{
        //	//DisplayAlert("Warning", "Please Input Username & Password", "Ok");
        //	//return;
        //}
        //else
        //{
        //          //await Navigation.PushAsync(new HomePage());
        //          await Shell.Current.GoToAsync("//HomePage");
        //      }

        await Shell.Current.GoToAsync("//HomePage");
    }

    private async void OnSignupTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Signup());
    }

    private async void OnForgotPasswordTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new ForgotPassword());
    }
}