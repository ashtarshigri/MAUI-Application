namespace INOVI;

public partial class ForgotPassword : ContentPage
{
	public ForgotPassword()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void SendEmailClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EmailVerification());
    }

    private async void btnCancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}