using SimpleRegisterAndLogin.Views;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleRegisterAndLogin.ViewModels
{
    public class LoginPageViewModel : INotifyPropertyChanged
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool HidePassword { get; set; }
        public ICommand LoginCommand =>
            new Command(Login);
        public ICommand SignUpCommand =>
            new Command(NavigateSignUp);
        public ICommand ShowPasswordCommand =>
            new Command(HidePasswordChange);


        public event PropertyChangedEventHandler PropertyChanged;

        public LoginPageViewModel()
        {
            HidePassword = true;
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

        public void HidePasswordChange()
        {
            HidePassword = !HidePassword;
        }
    }
}
