using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03
{
    static class Program
    {
        /*******************************
        *Chris McClure
        *9-15-16
        *Student Grade Update, Delete, Add
        *Add student grades, edit grades, and delete grades from a text file
        *********************************/
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmStudentScores());
        }
    }
}
