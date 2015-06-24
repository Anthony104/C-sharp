using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class vehicle
    {
        private string _make;
        private string _model;
        private int _elapsedMilage; 

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int ElapsedMilage
        {
            get { return _elapsedMilage; }
            set { _elapsedMilage = value; }
        }
    }
}
