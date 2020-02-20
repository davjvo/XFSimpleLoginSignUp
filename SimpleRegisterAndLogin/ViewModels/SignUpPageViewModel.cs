using SimpleRegisterAndLogin.Views;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleRegisterAndLogin.ViewModels
{
    public class SignUpPageViewModel : INotifyPropertyChanged
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordRepeat { get; set; }
        public bool HidePassword { get; set; }
        public string EyeIcon
        {
            get
            {
                return HidePassword ? "eye" : "eyeHidden";
            }
        }
        public ICommand SignUpCommand =>
            new Command(SignUp);
        public ICommand ShowPasswordCommand =>
            new Command(HidePasswordChange);

        public event PropertyChangedEventHandler PropertyChanged;
        public SignUpPageViewModel()
        {
            HidePassword = true;
        }


        public async void SignUp()
        {
            var message = "";

            if (string.IsNullOrEmpty(Email))
            {
                message = "Email is required.";
            }

            if (string.IsNullOrEmpty(UserName))
            {
                message = $"{message} \nUsername is required.";
            }

            if (string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(PasswordRepeat))
            {
                message = $"{message} \nPassword is required.";
            }
            else if (!Password.Equals(PasswordRepeat))
            {
                message = $"{message} \nThe passwords must be the same.";
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
        public void HidePasswordChange()
        {
            HidePassword = !HidePassword;
        }
    }
}
