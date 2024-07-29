using MrMath.Views;

namespace MrMath
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            //AppShell.SetNavBarIsVisible(this, false);
        }

        private void debugButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.Debug());
        }
    }

}
