using MrMath.Models;

namespace MrMath.Views;

public partial class SignPage : ContentPage
{
	public SignPage()
	{
		InitializeComponent();
        AppShell.SetNavBarIsVisible(this, false);
    }

    private async void signButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            Registro r = new Registro()
            {
                Nome = entryNome.Text,
                Email = entryEmail.Text,
                Senha = entrySenha.Text,
                Data = entryData.Text,

            };

            await App.Db.Insert(r);
            await DisplayAlert("Sucesso", "Registro efetuado", "OK");
            await Navigation.PushAsync(new MainPage());  
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}