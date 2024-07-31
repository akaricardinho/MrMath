
namespace MrMath
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void debugButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.Debug());
        }
    }

}
