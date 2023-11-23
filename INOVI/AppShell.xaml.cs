namespace INOVI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void LogOutClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//MainPage");
        }

        private async void OnProfileClicked(object sender, TappedEventArgs e)
        {
            PickOptions options = new PickOptions();
            try
            {
                var result = await FilePicker.Default.PickAsync(options);
                if (result != null)
                {
                    if (result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
                       result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase) ||
                       result.FileName.EndsWith("doc", StringComparison.OrdinalIgnoreCase) ||
                       result.FileName.EndsWith("docx", StringComparison.OrdinalIgnoreCase) ||
                       result.FileName.EndsWith("webp", StringComparison.OrdinalIgnoreCase) ||
                       result.FileName.EndsWith("jpeg", StringComparison.OrdinalIgnoreCase)
                       )
                    {
                        var stream = await result.OpenReadAsync();
                        var image = ImageSource.FromStream(() => stream);
                        Img.Source = image;
                    }
                }
            }
            catch { }
        }
    }
}