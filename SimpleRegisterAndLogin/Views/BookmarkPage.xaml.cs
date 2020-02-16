using SimpleRegisterAndLogin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleRegisterAndLogin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookmarkPage : ContentPage
    {
        public BookmarkPage()
        {
            InitializeComponent();
            BindingContext = new BookmarkPageViewModel();
        }
    }
}