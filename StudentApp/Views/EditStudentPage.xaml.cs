namespace StudentApp.Views;

public partial class EditStudentPage : ContentPage
{
	public EditStudentPage()
	{
        InitializeComponent();
	}

    private void cancelButton_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }
}