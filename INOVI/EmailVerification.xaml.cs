namespace INOVI;

public partial class EmailVerification : ContentPage
{
	public EmailVerification()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);

        // Event handlers for text changed (optional, for validation)
        //firstDigitEntry.TextChanged += Entry_TextChanged;
        //secondDigitEntry.TextChanged += Entry_TextChanged;
        //thirdDigitEntry.TextChanged += Entry_TextChanged;
        //fourthDigitEntry.TextChanged += Entry_TextChanged;
    }

    //private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    //{
    //    if (!int.TryParse(e.NewTextValue, out int result))
    //    {
    //        // If non-numeric value entered, clear the Entry field
    //        ((Entry)sender).Text = string.Empty;
    //    }
    //}

    private async void VerifyClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EnterNewPassword());
    }

    private async void btnCancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ForgotPassword());
    }
}