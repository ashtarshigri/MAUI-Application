using INOVI.Pages;

namespace INOVI;

public partial class EnterNewPassword : ContentPage
{
	public EnterNewPassword()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void NewPasswordClicked(object sender, EventArgs e)
    {
        
        //await Navigation.PushAsync(new HomePage());
        await Shell.Current.GoToAsync("//HomePage");

    }

    private async void btnCancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EmailVerification());
    }
}