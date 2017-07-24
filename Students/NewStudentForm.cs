using StudentService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmileBase.Students
{
    public partial class NewStudentForm : Form
    {
        Student Student;
        StudentWriter StudentWriter;

        public NewStudentForm()
        {
            InitializeComponent();
            Student = new Student();
            StudentWriter = new StudentWriter();
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            Student.FirstName = contactControl1.FirstNameTextBox.Text;
            Student.LastName = contactControl1.LastNameTextBox.Text;
            Student.DateOfBirth = contactControl1.DateOfBirthDatePicker.DateTime.Date;
            Student.MobilePhone = contactControl1.MobileTextBox.Text;
            Student.EmailAddress = contactControl1.EmailTextBox.Text;

            var savedStudent = StudentWriter.AddStudent(Student);
            MessageBox.Show($"Student No {savedStudent.Id} added to the database ! (Has to be implemented)");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }
    }
}
