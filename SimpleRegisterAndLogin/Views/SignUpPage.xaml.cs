using SimpleRegisterAndLogin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleRegisterAndLogin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
            BindingContext = new SignUpPageViewModel();
        }
    }
}