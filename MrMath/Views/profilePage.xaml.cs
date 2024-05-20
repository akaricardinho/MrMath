namespace MrMath.Views;

public partial class profilePage : ContentPage
{
	public profilePage()
	{
		InitializeComponent();
        AppShell.SetNavBarIsVisible(this, false);
    }

    private void logoutButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.SignPage());
    }
}