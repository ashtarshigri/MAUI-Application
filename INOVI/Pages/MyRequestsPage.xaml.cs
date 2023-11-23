using Microsoft.Maui.Controls;

namespace INOVI.Pages;

public partial class MyRequestsPage : ContentPage
{
	public MyRequestsPage()
	{
		InitializeComponent();
	}
    private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
           var picker = sender as Picker;
            if (picker != null && picker.SelectedIndex != -1)
            {
                var selectedOption = picker.SelectedItem as string;
                // Use the selectedOption variable as needed
            }
    }
    private async void BacktoDashboardButton_Clicked(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new HomePage());
        await Shell.Current.GoToAsync("//HomePage");
    }

    private async void OnAddAttachmentClicked(object sender, EventArgs e)
    {
        //PickOptions options = new PickOptions();
        //try
        //{
        //    var result = await FilePicker.Default.PickAsync(options);
        //    if (result != null)
        //    {
        //        if(result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase)||
        //           result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase)||
        //           result.FileName.EndsWith("doc", StringComparison.OrdinalIgnoreCase)||
        //           result.FileName.EndsWith("docx", StringComparison.OrdinalIgnoreCase)||
        //           result.FileName.EndsWith("webp", StringComparison.OrdinalIgnoreCase)||
        //           result.FileName.EndsWith("jpeg", StringComparison.OrdinalIgnoreCase)
        //           )
        //        {
        //            var stream = await result.OpenReadAsync();
        //            var image = ImageSource.FromStream(() => stream);
        //            Img.Source = image;
        //        }
        //    }
        //}
        //catch { }




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
        }



        //-------------------------------------End Multiple file Select--------------------------------








    }

  
  
}