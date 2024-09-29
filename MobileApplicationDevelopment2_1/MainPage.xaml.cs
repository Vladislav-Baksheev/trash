
using MobileApplicationDevelopment2_1.ViewModel;

namespace MobileApplicationDevelopment2_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainVM();
        }

        private async void ToCreateNotePage(object? sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CreateNotePage());
        }
    }

}
