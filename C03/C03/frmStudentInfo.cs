using CustomerMaintenance;
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


    public partial class frmStudentInfo : Form
    {
        private int action = 0;
        private int index = 0;
        enum Action //Keeps track of what is the purpose of the form
        {
            add = 1,
            update = 2,
            delete = 3
        }
        Student student;

        //Define delegate
        public delegate void MakeStudentEventHandler(Student student, int action, int index);

        //Define event for when a customer is added
        public event MakeStudentEventHandler StudentMade;

        public frmStudentInfo()
        {
            InitializeComponent();

        }

        //Opens form and lets it know the purpose is to add student
        public void AddStudentInfo()
        {
            this.Show();
            action = (int)Action.add;
        }

        //Opens form and lets it know the purpose is to update student
        public void UpdateStudentInfo(Student student, int index)
        {
            this.Text = "Update Student Information";
            this.index = index;
            this.Show();
            action = (int)Action.update;

            PopulateTextBoxes(student);

            //set readonly for name and id
            txtNameStudent.ReadOnly = true;
            txtIDStudent.ReadOnly = true;
        }

        //Opens form and lets it know the purpose is to delete student
        public void DeleteStudentInfo(Student student,int index)
        {
            this.Text = "Delete Student Information";
            this.Tag = "Delete";
            this.index = index;
            this.Show();
            action = (int)Action.delete;

            
            PopulateTextBoxes(student);

            //set readonly for all textboxes
            txtNameStudent.ReadOnly = true;
            txtIDStudent.ReadOnly = true;
            txtMidTermGrade.ReadOnly = true;
            txtFinalGrade.ReadOnly = true;
        }


        //Validate information and pass student back to correct area
        private void btnOK_Click(object sender, EventArgs e)
        {
          

            //if (this.Tag.ToString() == "Delete")// I didn't want to miss any points
            //{
            //    this.Tag = "ok";
            //    this.Close();
            //}

            if (ValidateAllStudentInfo())
            {
                //If everything is valid create new student object with to do parameters
                student = new Student(
                    txtNameStudent.Text,
                    txtIDStudent.Text,
                    Convert.ToInt32(txtMidTermGrade.Text),
                    Convert.ToInt32(txtFinalGrade.Text)
                    );


                //Close form
                this.Close();

                //Call event method
                OnStudentMade();
         
             
            }
        }

        //Raise event when student added
        protected virtual void OnStudentMade()
        {
            if (StudentMade != null)//Check to make sure there is a subscriber for event
            {
                StudentMade(student, action, index);//if so, then pass the class level customer, action, and index 
            }
        }


       private void PopulateTextBoxes(Student student)
        {
            //popualte the textboxes
            txtNameStudent.Text = student.StudentName;
            txtIDStudent.Text = student.StudentID;
            txtMidTermGrade.Text = student.MidtermGrade.ToString();
            txtFinalGrade.Text = student.FinalGrade.ToString();
        }


       //closes form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /// <summary>
        /// Validated all possible entries on the form
        /// </summary>
        /// <returns></returns>
        public bool ValidateAllStudentInfo()
        {
            if (Validator.IsPresent(txtNameStudent) && Validator.IsInt32(txtIDStudent) && 
                Validator.IsWithinRange(txtIDStudent, 1, 999999) &&        
                Validator.IsInt32(txtMidTermGrade) &&  Validator.IsInt32(txtFinalGrade) &&
                Validator.IsWithinRange(txtMidTermGrade, 1, 100) && Validator.IsWithinRange(txtFinalGrade, 1, 100))
            {
                return true;
            }          
            return false;
        }

       

      
    }
}
