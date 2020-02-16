using SimpleRegisterAndLogin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleRegisterAndLogin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TopFriendsPage : ContentPage
    {
        public TopFriendsPage()
        {
            InitializeComponent();
            BindingContext = new TopFriendsPageViewModel();
        }
    }
}