using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_2
{
    internal class Animal
    {
        //Field
        private string _species;

        //Constructor
        public Animal (string species)
        {
            _species = species;
        }

        //Species Property
        public string Species
        {
            get { return _species; }
            set { _species = value; }
        }

        //Method 'Make Sound'
        public virtual void MakeSound()
        {
            MessageBox.Show("Grrrrr");
        }
    }
}
