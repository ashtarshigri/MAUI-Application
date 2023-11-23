namespace INOVI.Pages;

public partial class AddApplication : ContentPage
{
    public AddApplication()
    {
        InitializeComponent();
    }
    void OnEditorTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = editor.Text;
    }
    void OnEditorCompleted(object sender, EventArgs e)
    {
        string text = ((Editor)sender).Text;
    }

    private bool attachmentClickEnabled = true;
    private async void OnAddAttachmentClicked(object sender, EventArgs e)
    {
        //-------------------------------------Multiple file Select--------------------------------
        if (attachmentClickEnabled)
        {
            var results = await FilePicker.PickMultipleAsync();
            foreach (var result in results)
            {
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
                        var image = new Image
                        {
                            Source = ImageSource.FromStream(() => stream),
                            HeightRequest = 50,
                            WidthRequest = 50,
                            Margin = new Thickness(5)
                        };
                        ImageContainer.Children.Add(image);
                    }
                }
                bool fileSelected = true; // Replace this with your file selection logic

                Img.IsVisible = !fileSelected;
                UploadLabel.IsVisible = !fileSelected;
                SelectFileButton.IsVisible = fileSelected;
            }

        }

        //-------------------------------------End Multiple file Select--------------------------------





        attachmentClickEnabled = false;


    }

    private async void SelectFileButton_Clicked(object sender, EventArgs e)
    {



        //-------------------------------------Multiple file Select--------------------------------

        var results = await FilePicker.PickMultipleAsync();
        foreach (var result in results)
        {
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
                    var image = new Image
                    {
                        Source = ImageSource.FromStream(() => stream),
                        HeightRequest = 50,
                        WidthRequest = 50,
                        Margin = new Thickness(5)
                    };
                    ImageContainer.Children.Add(image);
                }
            }



            // Logic to handle file selection via the button
            // Once the file is selected, you may want to update the visibility again
            //bool fileSelected = false; // Replace this with your file selection logic after using the button

            //Img.IsVisible = !fileSelected;
            //UploadLabel.IsVisible = !fileSelected;
            //SelectFileButton.IsVisible = fileSelected;

        }
    }

    private async void btnCancel_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//HomePage");
    }

    private async void btnSendButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//HomePage");
    }
}