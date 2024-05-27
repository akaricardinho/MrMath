using MrMath.Models;
using System.Collections.ObjectModel;

namespace MrMath.Views;

public partial class Debug : ContentPage
{
	public Debug()
	{
		InitializeComponent();
        AppShell.SetNavBarIsVisible(this, false);

        List<string> contacts = new List<string>()
        {
            "John doe",
            "Jane doe",
            "Pedro Pinto"
        };

        lst_contas.ItemsSource = contacts;
	}

    ObservableCollection<Registro> lista_contas = new ObservableCollection<Registro>();

    protected async override void OnAppearing()
    {
        if (lista_contas.Count == 0)
        {
            List<Registro> tmp = await App.Db.GetAll();
            foreach (Registro r in tmp)
            {
                lista_contas.Add(r);
            };
        }

    }


    private void lst_contas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {

    }
}