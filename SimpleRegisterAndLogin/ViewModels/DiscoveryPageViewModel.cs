using SimpleRegisterAndLogin.Controls;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleRegisterAndLogin.ViewModels
{
    public class DiscoveryPageViewModel
    {
        public Frame LastElementTouched { get; set; }

        public ICommand CardViewSelectedCommand =>
                    new Command<Frame>((elementTouched) => ChangeBackgroundColor(elementTouched));

        private void ChangeBackgroundColor(Frame elementTouched)
        {
            if (LastElementTouched != null)
            {
                LastElementTouched.BackgroundColor = Color.White;
            }

            elementTouched.BackgroundColor = Color.FromHex("#415190");
            LastElementTouched = elementTouched;
        }
    }
}
