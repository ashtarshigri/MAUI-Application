namespace INOVI.Pages;

public partial class HomePage : ContentPage
{
    [Obsolete]
    public HomePage()
	{
		InitializeComponent();

        NavigationPage.SetHasBackButton(this, false); // Hide the back button


        // Create the first toolbar item with an icon
        var icon1 = new FileImageSource { File = "add.svg" };
        var toolbarItem1 = new ToolbarItem { IconImageSource = icon1 };

        // Create the second toolbar item with another icon
        var icon2 = new FileImageSource { File = "reload.svg" };
        var toolbarItem2 = new ToolbarItem { IconImageSource = icon2 };

        // Add both toolbar items to the navigation bar
        if (Device.RuntimePlatform == Device.Android)
        {
            Application.Current.MainPage.ToolbarItems.Add(toolbarItem1);
            Application.Current.MainPage.ToolbarItems.Add(toolbarItem2);
        }
        else if (Device.RuntimePlatform == Device.iOS)
        {
            // For iOS, set a dummy TitleView to show the icons
            NavigationPage.SetTitleView(this, new Label()); // Set a dummy TitleView to show the icons
        }

        // Handle toolbar item click events
        toolbarItem1.Clicked += OnToolbarItem1Clicked;
        toolbarItem2.Clicked += OnToolbarItem2Clicked;
    }
    private async void OnToolbarItem1Clicked(object sender, EventArgs e)
    {
        // Handle the click action for the first toolbar item
        //await Shell.Current.GoToAsync("//AddApplication");
        await Navigation.PushAsync(new AddApplication());
    }

    private async void OnToolbarItem2Clicked(object sender, EventArgs e)
    {
        // Handle the click action for the second toolbar item
        await DisplayAlert("Reload", "Loading.....", "OK");
    }

    private async void ApplicationDetailClicked(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new MyRequestsPage());
    }

    private async void ApplicationDetail2Clicked(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new MyRequestsPage());
    }

    private async void ApplicationDetail3Clicked(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new MyRequestsPage());
    }
}

