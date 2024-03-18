using Phone.Views;

namespace Phone
{
    public partial class MainPage : FlyoutPage
    {

        public MainPage()
        {
            InitializeComponent();

            Flyout = new Master();

            Detail = new NavigationPage(new Detail());

            App._flyOutPage = this;
        }

    }

}
