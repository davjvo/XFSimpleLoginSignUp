using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleRegisterAndLogin.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardView : ContentView
    {
        public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(
            nameof(CardTitle), typeof(string), typeof(CardView), string.Empty
        );

        public static readonly BindableProperty CardSubTitleProperty = BindableProperty.Create(
            nameof(CardSubTitle), typeof(string), typeof(CardView), string.Empty
        );

        public static readonly BindableProperty CardIconProperty = BindableProperty.Create(
            nameof(CardIcon), typeof(ImageSource), typeof(CardView), default(ImageSource)
        );

        public static readonly BindableProperty TouchedCommandProperty = BindableProperty.Create(
            nameof(TouchedCommand), typeof(ICommand), typeof(CardView), null
        );

        public string CardTitle
        {
            get => (string)GetValue(CardTitleProperty);
            set => SetValue(CardTitleProperty, value);
        }
        public string CardSubTitle
        {
            get => (string)GetValue(CardSubTitleProperty);
            set => SetValue(CardSubTitleProperty, value);
        }
        public ImageSource CardIcon
        {
            get => (ImageSource)GetValue(CardIconProperty);
            set => SetValue(CardIconProperty, value);
        }
        public ICommand TouchedCommand
        {
            get => (ICommand)GetValue(TouchedCommandProperty);
            set => SetValue(TouchedCommandProperty, value);
        }

        public CardView()
        {
            InitializeComponent();
        }

        private void MainFrame_TapHandler(object sender, System.EventArgs e)
        {
            var frame = (Frame)sender;
            frame.BackgroundColor = Color.FromHex("#415190");
            Device.StartTimer(System.TimeSpan.FromSeconds(.1), () =>
            {
                frame.BackgroundColor = Color.White;
                return false;
            });

        }
    }
}