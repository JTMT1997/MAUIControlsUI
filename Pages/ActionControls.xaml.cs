namespace MauiControls.Pages;

public partial class ActionControls : ContentPage
{
	public ActionControls()
	{
		InitializeComponent();
	}

    private void demoButton_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Coding Droplets ", "You have click demo", "oke");
    }

    private void demoImageButton_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets ", "You have clicked the download button", "oke");
    }

    private void demoSearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets ", $"You've clicked Searched for{demoSearchBar.Text}", "oke");
    }

    private void facebookSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets ", "You've clicked the facebook button", "oke");
    }

    private void instagramSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets ", "You've clicked the instagram button", "oke");
    }

    private void twitterSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets ", "You've clicked the twitter button", "oke");
    }

    private void linkedinSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets ", "You've clicked the linkedin button", "oke");
    }
}