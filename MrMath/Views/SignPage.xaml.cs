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

            if (string.IsNullOrEmpty(entryNome.Text.ToString())) 
            {
                await DisplayAlert("Ops","Campo 'Nome' est� vazio", "OK");
            }
            else if (string.IsNullOrEmpty(entryEmail.Text.ToString()))
            {
                await DisplayAlert("Ops", "Campo 'Email' est� vazio", "OK");
            }
            else if (string.IsNullOrEmpty(entrySenha.Text.ToString()))
            {
                await DisplayAlert("Ops", "Campo 'Senha' est� vazio", "OK");
            }
            else if (string.IsNullOrEmpty(entrySenha2.Text.ToString()))
            {
                await DisplayAlert("Ops", "Campo 'Senha' est� vazio", "OK");
            }
            else if (string.IsNullOrEmpty(entryData.Text.ToString()))
            {
                await DisplayAlert("Ops", "Campos 'Data' est� vazio", "OK");
            }


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