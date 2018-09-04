using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2
{
    class CompSciStudent : Student
    {
        //Constants
        private double MATH_HOURS = 20;
        private double CS_HOURS = 40;
        private double GEN_HOURS = 60;

        //Field
        private string _academicTrack;

        //Constructor
        public CompSciStudent(string name, string id, string track)
            : base (name, id)
        {
            _academicTrack = track;
        }

        //Academic track property
        public string AcademicTrack
        {
            get { return _academicTrack; }
            set { _academicTrack = value; }
        }

        //RequiredHours Property
        public override double RequiredHours
        {
            get { return MATH_HOURS + CS_HOURS + GEN_HOURS; }
        }
    }
}
