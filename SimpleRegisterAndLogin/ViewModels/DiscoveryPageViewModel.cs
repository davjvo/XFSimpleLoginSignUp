using SimpleRegisterAndLogin.Controls;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleRegisterAndLogin.ViewModels
{
    public class DiscoveryPageViewModel
    {
        public CardView LastElementTouched { get; set; }
        public ICommand CardViewSelectedCommand { get; set; }

        public DiscoveryPageViewModel()
        {
            CardViewSelectedCommand = new Command<CardView>((CardView elementTouched) =>
            {
                if (LastElementTouched != null)
                {
                    LastElementTouched.BackgroundColor = Color.White;
                }

                elementTouched.BackgroundColor = Color.FromHex("#415190");
                LastElementTouched = elementTouched;
            });
        }
    }
}
