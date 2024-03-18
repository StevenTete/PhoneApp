using The49.Maui.BottomSheet;

namespace Phone.Views;

public partial class Detail : ContentPage
{
	public Detail()
	{
		InitializeComponent();

		BindingContext = App.Contacts;
		
	}

    private void OpenAddContactView(object sender, EventArgs e)
    {
		App.bottomSheet?.ShowAsync();
    }
}