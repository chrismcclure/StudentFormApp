using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03
{
    static class  StudentDB
    {

        /*******************************
        *Chris McClure
        *9-15-16
        *Student Grade Update, Delete, Add
        *Add student grades, edit grades, and delete grades from a text file
        *********************************/
        private const string dir = @"..\..\";              //will save file with solution
        private const string path = dir + "Students.txt";


        public static List<Student> GetStudent()
        {
            // if the directory doesn't exist, create it
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
           

            // create the object for the input stream for a text file
            StreamReader textIn =
                new StreamReader(
                    new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            //List of students
            List<Student> students = new List<Student>();

            //Read through text file
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split(',');
                Student student = new Student();
                student.StudentName = columns[0];
                student.StudentID = columns[1];
                student.MidtermGrade = Convert.ToInt32(columns[2]);
                student.FinalGrade = Convert.ToInt32(columns[3]);
                students.Add(student);
            }

            //Close the streamreader
            textIn.Close();

            //return the list of students
            return students;
        }

        public static void SaveStudents(List<Student> students)
        {

            // if the directory doesn't exist, create it
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            // create the output stream for a text file that exists
            StreamWriter textOut =
            new StreamWriter(
            new FileStream(path, FileMode.Create, FileAccess.Write));

            foreach (Student student in students)
            {
                textOut.Write(student.StudentName + ",");
                textOut.Write(student.StudentID + ",");
                textOut.Write(student.MidtermGrade + ",");
                textOut.WriteLine(student.FinalGrade);

            }

            // write the end of the document
            textOut.Close();
        }

    }
}
