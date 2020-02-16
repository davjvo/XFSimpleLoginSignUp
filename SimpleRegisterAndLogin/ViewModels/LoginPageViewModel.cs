using SimpleRegisterAndLogin.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleRegisterAndLogin.ViewModels
{
    public class LoginPageViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICommand LoginCommand { get; set; }
        public ICommand SignUpCommand { get; set; }

        public LoginPageViewModel()
        {
            LoginCommand = new Command(Login);
            SignUpCommand = new Command(NavigateSignUp);
        }

        public async void Login()
        {
            string message = "";

            if (string.IsNullOrEmpty(UserName))
            {
                message = "UserName or Email is required.";
            }

            if (string.IsNullOrEmpty(Password))
            {
                message = $"{message} \nPassword is required.";
            }

            if (!string.IsNullOrEmpty(message))
            {
                await Application.Current.MainPage.DisplayAlert("Alert!", message, "Ok");
            }
            else
            {
                Application.Current.MainPage = new MainTabsPage();
            }
        }

        public async void NavigateSignUp()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SignUpPage());
        }
    }
}
