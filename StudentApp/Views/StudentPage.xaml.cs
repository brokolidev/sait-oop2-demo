using StudentApp.Model;
using System.Collections.ObjectModel;

namespace StudentApp.Views;

public partial class StudentPage : ContentPage
{
	public StudentPage()
	{
		InitializeComponent();

		listOfStudent.ItemsSource = StudentRepository.GetAllStudents();

    }

	private void submitButton_Clicked(object sender, EventArgs e)
	{
		//entryName.Text = "This is OOP2 Class";
		//studentNameLabel.Text = "Student Name";

		Shell.Current.GoToAsync(nameof(StudentDetailPage));
	}


    private void listOfStudent_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
		System.Diagnostics.Debug.WriteLine(((Student)listOfStudent.SelectedItem).StudentId);
		Shell.Current.GoToAsync($"{nameof(StudentDetailPage)}" + 
			$"?Id={((Student)listOfStudent.SelectedItem).StudentId}");

	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		var student = new ObservableCollection<Student>(StudentRepository.GetAllStudents());

		listOfStudent.ItemsSource = student;
    }

    private void addStudentButton_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(AddStudentPage));
    }

    private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
		// on window machine, it works without observable collection
		var students = new ObservableCollection<Student>(
			StudentRepository.SearchforStudents(searchBar.Text));

		listOfStudent.ItemsSource = students;
    }
}