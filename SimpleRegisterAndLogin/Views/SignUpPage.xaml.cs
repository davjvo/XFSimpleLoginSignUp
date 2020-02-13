using System;
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
        }

        private async void ButtonSingUp_TappedHandler(object sender, EventArgs e)
        {
            var message = "";

            if (string.IsNullOrEmpty(Email.Text))
            {
                message = string.Concat(message, "Email is required.");
            }

            if (string.IsNullOrEmpty(UserName.Text))
            {
                message = string.Concat(message, "\nUserName is required.");
            }

            if (string.IsNullOrEmpty(Password.Text) || string.IsNullOrEmpty(PasswordRepeat.Text))
            {
                message = string.Concat(message, "\nPassword is required.");
            }
            else if(!Password.Text.Equals(PasswordRepeat.Text))
            {
                message = string.Concat(message, "\nThe passwords most be the same.");
            }

            if (!string.IsNullOrEmpty(message))
            {
                await DisplayAlert("Alert!", message, "Ok");
            }
            else
            {
                Application.Current.MainPage = new MainTabsPage();
            }
        }
    }
}