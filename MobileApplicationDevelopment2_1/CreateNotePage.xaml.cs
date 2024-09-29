using MobileApplicationDevelopment2_1.ViewModel;
using System.Security.AccessControl;

namespace MobileApplicationDevelopment2_1
{
    public partial class CreateNotePage : ContentPage
    {
        public CreateNotePage()
        {
            InitializeComponent();
            BindingContext = new MainVM();
        }

        private async void BackToMainPage(object? sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }

}
