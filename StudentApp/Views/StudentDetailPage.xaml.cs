using StudentApp.Model;
using System.Diagnostics;

namespace StudentApp.Views;

[QueryProperty(nameof(StudentId), "Id")]
public partial class StudentDetailPage : ContentPage
{
	private Student student;
	
	public StudentDetailPage()
	{
		InitializeComponent();
	}

    private void CancelButton_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }

    private void UpdateButton_Clicked(object sender, EventArgs e)
    {
        student.Name = entryName.Text;
		student.Email = entryEmail.Text;
		student.Address = entryAddress.Text;
		student.Phone = entryPhone.Text;

        Console.WriteLine(entryPhone.Text);

        StudentRepository.UpdateStudentDetails(student.StudentId, student);
		Shell.Current.GoToAsync("..");
    }

    public string StudentId 
	{
		set 
		{
            student = StudentRepository.GetStudentById(int.Parse(value));
            System.Diagnostics.Debug.WriteLine(value);
			title.Text = $"Welcome to {student.Name} Page";
			entryName.Text = student.Name;
			entryEmail.Text = student.Email;
			entryPhone.Text = student.Phone;
			entryAddress.Text = student.Address;
		}

	}

}