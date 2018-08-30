using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _10_2.Classes;
using _10_2;

namespace AbstractClasses
{
    public partial class AbstractClasses : Form
    {

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOtherForm_Click(object sender, EventArgs e)
        {
            //Hide the current form
            this.Hide();
            //Create the object for the new form
            Polymorphism polymorphism = new Polymorphism();
            //Display the new form for the user
            polymorphism.ShowDialog();
            //Close this current form
            this.Close();
        }
        
        private void btnGetHours_Click(object sender, EventArgs e)
        {
            //Variables to hold inputs
            string name, id, track;

            //Get the students name and ID
            name = tbStudentName.Text;
            id = tbIDNumber.Text;

            //Get the student's academic track
            if (rbInfoSystems.Checked)
            {
                track = "Information Systems";
            }
            else
            {
                track = "Software Engineering";
            }

            //Create the ComSciStudent object
            CompSciStudent compSci = new CompSciStudent(name, id, track);
        }
    }
}
