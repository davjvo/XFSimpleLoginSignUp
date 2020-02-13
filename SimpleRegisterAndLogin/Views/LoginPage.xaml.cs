using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleRegisterAndLogin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void LabelSignUp_TappedHandler(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }

        private async void ButtonLogin_TappedHandler(object sender, EventArgs e)
        {
            string message = "";

            if (string.IsNullOrEmpty(UserName.Text))
            {
                message = "UserName or Email is required.";
            }

            if (string.IsNullOrEmpty(Password.Text))
            {
                message = $"{message} \nPassword is required.";
            }

            if (!string.IsNullOrEmpty(message))
            {
                await DisplayAlert("Alert!", message, "Ok");
            }
            else
            {
                Application.Current.MainPage =  new MainTabsPage();
            }
        }
    }
}