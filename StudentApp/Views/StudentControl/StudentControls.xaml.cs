namespace StudentApp.Views.StudentControl;

public partial class StudentControls : ContentView
{
    public event EventHandler<EventArgs> OnUpdate;
    public event EventHandler<EventArgs> OnCancel;

    public StudentControls()
	{
		InitializeComponent();
	}

    // Creating properties to access xaml tags in UI
    public string Name
    {
        get => entryName.Text;
        set => entryName.Text = value;
    }

    public string Address
    {
        get => entryAddress.Text;
        set => entryAddress.Text = value;
    }

    public string Email
    {
        get => entryEmail.Text;
        set => entryEmail.Text = value;
    }

    public string Phone
    {
        get => entryPhone.Text;
        set => entryPhone.Text = value;
    }

    private void UpdateButton_Clicked(object sender, EventArgs e)
    {
    }

    private void CancelButton_Clicked(object sender, EventArgs e)
    {
    }
}