using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace Phone.Views;

public partial class AddContactView
{
	public AddContactView()
	{
		InitializeComponent();

        App.bottomSheet = this;
	}

    private void CloseAddContactView(object sender, EventArgs e)
    {
		App.bottomSheet?.DismissAsync();
    }

    private void SaveContact(object sender, EventArgs e)
    {
        AddContact(entryName.Text, entryOccupation.Text, entryPhoneNumber.Text, entryAddress.Text, entryEmail.Text);
        ShowToast("New contact added.");
        CleanEntries();
    }

    void AddContact(string name, string occupation, string phoneNumber, string address, string email)
    {
        App.Contacts.Add(new Models.Contact
        {
            Name = name,
            Occupation = occupation,
            PhoneNumber = phoneNumber,
            Address = address,
            Email = email
        });

        App.bottomSheet?.DismissAsync();
    }

    void ShowToast(string message)
    {
        string text = message;
        ToastDuration duration = ToastDuration.Long;
        double fontSize = 20;
        var toast = Toast.Make(text, duration, fontSize);
        toast.Show();
    }

    void CleanEntries()
    {
        // Se limpian los entrys
        entryName.Text = string.Empty;
        entryOccupation.Text = string.Empty;
        entryPhoneNumber.Text = string.Empty;
        entryAddress.Text = string.Empty;
        entryEmail.Text = string.Empty;

        // Se desenfocan los entrys para ocultar el teclado
        entryName.Unfocus();
        entryOccupation.Unfocus();
        entryPhoneNumber.Unfocus();
        entryAddress.Unfocus();
        entryEmail.Unfocus();
    }

}