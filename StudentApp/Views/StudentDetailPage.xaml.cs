using StudentApp.Model;
using System.Diagnostics;

namespace StudentApp.Views;

//[QueryProperty(nameof(StudentId), "Id")]
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
		student.Name = StudentControl.Name;
		student.Email = StudentControl.Email;
		student.Address = StudentControl.Address;
		student.Phone = StudentControl.Phone;

		StudentRepository.UpdateStudentDetails(student.StudentId, student);
		Shell.Current.GoToAsync("..");
	}

	public string StudentId
	{
		set
		{
			student = StudentRepository.GetStudentById(int.Parse(value));
			//System.Diagnostics.Debug.WriteLine(value);
			StudentControl.Name= student.Name;
            StudentControl.Email = student.Email;
            StudentControl.Phone = student.Phone;
            StudentControl.Address = student.Address;
		}

	}

}