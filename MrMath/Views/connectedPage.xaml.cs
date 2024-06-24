namespace MrMath.Views;

public partial class connectedPage : ContentPage
{
	public connectedPage()
	{
		InitializeComponent();
	}

    private void profileIcon_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.profilePage());
    }

    private void debugButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.Debug());
    }
}