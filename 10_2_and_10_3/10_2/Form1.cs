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

namespace _10_2
{

    public partial class Form1 : Form
    {
        private Animal myAnimal = new Animal("Dog");

        public Form1()
        {
            InitializeComponent();
        }
    }
}
