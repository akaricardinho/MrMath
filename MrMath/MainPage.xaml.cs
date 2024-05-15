using MrMath.Views;

namespace MrMath
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void profileIcon_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.profilePage());
        }
    }

}
