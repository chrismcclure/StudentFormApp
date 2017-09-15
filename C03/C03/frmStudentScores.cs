using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03
{
    /*******************************
    *Chris McClure
    *9-15-16
    *Student Grade Update, Delete, Add
    *Add student grades, edit grades, and delete grades from a text file
    *********************************/

    public partial class frmStudentScores : Form
    {
        List<Student> students = null;
        public frmStudentScores()
        {
            InitializeComponent();
        }

        private void frmStudentScores_Load(object sender, EventArgs e)
        {
            //Get scores from DB and display them in the list box
            students = StudentDB.GetStudent();
            DisplayListBox(students);
        }


        //Button makes new object and tells the student info what the plan is: ADD NEW Student
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmStudentInfo studentInfo = new frmStudentInfo();
            studentInfo.AddStudentInfo();
            studentInfo.StudentMade += this.OnStudentMade;//Get event when student is made
        }

        //Button makes new object and tells the student info what the plan is: Update Student
        private void btnUpdate_Click(object sender, EventArgs e)
        {          
            if (lstStudents.SelectedIndex != -1)//Make sure a student is selected
            {
                frmStudentInfo studentInfo = new frmStudentInfo();
                int indexToUpdate = lstStudents.SelectedIndex;
                studentInfo.UpdateStudentInfo(students[indexToUpdate], indexToUpdate);
                studentInfo.StudentMade += this.OnStudentMade;//Get event when student is updated
            }
            else
            {
                MessageBox.Show("Please select a student to update");
            }
           
        }

        //Button makes new object and tells the student info what the plan is
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex != -1)//Make sure a student is selected
            {
                frmStudentInfo studentInfo = new frmStudentInfo();
                int indexToUpdate = lstStudents.SelectedIndex;
                studentInfo.DeleteStudentInfo(students[indexToUpdate], indexToUpdate);
                studentInfo.StudentMade += this.OnStudentMade;//Get event when student is deleted
            }
            else
            { 
                MessageBox.Show("Please select a student to delete");
                
            }
          
        }


        //Event handler method and based on what the action is, 
        //it takes care of the action(add, update, or delete)
        //The index is the numder of the student to either update or delete
        public void OnStudentMade(Student student, int action, int index)
        {
                switch (action)
                {

                    case 1:
                    //The student needs to be added
                    students.Add(student);
                    StudentDB.SaveStudents(students);
                    DisplayListBox(students);
                    break;

                    case 2:
                    //The student needs to be updated
                    students[index] = student;
                    StudentDB.SaveStudents(students);
                    DisplayListBox(students);
                    break;

                    case 3:
                    //The student needs to be deleted
                    students.RemoveAt(index);
                    StudentDB.SaveStudents(students);
                    DisplayListBox(students);
                    break;

                    default:
                    //The student didn't come across correctly
                    MessageBox.Show("Error");
                    break;
                }        
        }

 
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Displays students in listbox
        private void DisplayListBox(List<Student> studentsLocal)
        {
            lstStudents.Items.Clear();
            foreach (Student student in studentsLocal)
            {
                lstStudents.Items.Add(student.DisplayStudInfo(4));
            }
        }

       
    }
}
