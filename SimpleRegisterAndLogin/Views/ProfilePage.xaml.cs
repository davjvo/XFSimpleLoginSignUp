using SimpleRegisterAndLogin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleRegisterAndLogin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            BindingContext = new ProfilePageViewModel();
        }
    }
}