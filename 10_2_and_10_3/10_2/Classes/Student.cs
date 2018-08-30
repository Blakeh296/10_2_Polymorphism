using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    abstract class Student
    {
        //Fields
        private string _name;
        private string _id;

        //Constructor
        public Student(string name, string id)
        {
            _name = name;
            _id = id;
        }

        //Name Property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //ID Property
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        //Required Hours Property (Abstract)
        public abstract double RequiredHours
        {
            get;
        }
    }
}
