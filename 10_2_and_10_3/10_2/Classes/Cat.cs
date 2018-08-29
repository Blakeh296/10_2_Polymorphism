﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_2.Classes
{
    class Cat : Animal
    {
        //Field
        private string _name;

        //Constructor
        public Cat(string name) : base("Cat")
        {
            _name = name;
        }

        //Name Property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Method 'Make Sound'
        public override void MakeSound()
        {
            MessageBox.Show("Meow!");
        }
    }
}
