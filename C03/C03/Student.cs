using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03
{
    /*******************************
    *Chris McClure
    *9-15-16
    *Student Grade Update, Delete, Add
    *Add student grades, edit grades, and delete grades from a text file
    *********************************/

    public class Student
    {

        public string StudentName { get;  set; }
        public string StudentID { get;  set; }
        public int FinalGrade { get;  set; }
        public int MidtermGrade { get;  set; }


        public Student()
        {

        }


        public Student(string studentName, string studentID, int finalGrade, int midtermGrade)
        {
            this.StudentName = studentName;
            this.StudentID = studentID;
            this.FinalGrade = finalGrade;
            this.MidtermGrade = midtermGrade;
        }


        public string CalcLtrGrade()
        {
            string letterGrade = "";
            double averageGrade = (FinalGrade + MidtermGrade) / 2;

            //Start at the top and work down
            if (averageGrade >= 90)
            {
                letterGrade = "A";
            }
            else if (averageGrade >= 80)
            {
                letterGrade = "B";
            }
            else if (averageGrade >= 70)
            {
                letterGrade = "C";
            }
            else if(averageGrade >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            return letterGrade;//Return the new letter grade
        }

        //Display studion name, id, and letter grade
        public string DisplayStudInfo(int n)
        {

            //I made sure there was 4 spaces between each string, following the format from the specs:
            //Joe Studentbbbb#12345bbbbA 
            return StudentName.PadRight(n + StudentName.Length)  + "#" + StudentID.PadRight(n + StudentID.Length) + CalcLtrGrade();
        }

        public string DisplayStudInfo()
        {
            return StudentID + "\t" + StudentID;
        }

    }
}
