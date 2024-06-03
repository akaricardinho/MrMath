using MrMath.Models;
using System.Collections.ObjectModel;

namespace MrMath.Views;

public partial class Debug : ContentPage
{

    ObservableCollection<Registro> lista_contas = new ObservableCollection<Registro>();

    public Debug()
	{
		InitializeComponent();
        AppShell.SetNavBarIsVisible(this, false);

        lst_contas.ItemsSource = lista_contas;
	}


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

}