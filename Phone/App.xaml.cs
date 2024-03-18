using Phone.Views;

namespace Phone
{
    public partial class App : Application
    {
        public static FlyoutPage? _flyOutPage { get; set; }
        public static AddContactView? bottomSheet { get; set; }
        public static List<Models.Contact>? Contacts { get; set; }


        public App()
        {
            InitializeComponent();

            Contacts = new List<Models.Contact>();
            Contacts.Add(new Models.Contact
            {
                Name = "John Doe",
                Occupation = "Software Developer",
                PhoneNumber = "123-456-7890",
                Address = "1234 Elm St",
                Email = "hola@cecar.com"
            });

            MainPage = new MainPage();

            bottomSheet = new AddContactView();

            bottomSheet.HasHandle = true;
            bottomSheet.HasBackdrop = true;
            bottomSheet.IsCancelable = true;
        }
    }
}

