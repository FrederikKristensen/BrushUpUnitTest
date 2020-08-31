using System;
using System.Collections.Generic;
using System.Text;

namespace BrushUpUnitTest
{
    public enum Gender
    {
        Cisgender, Transgender
    }

    class Teacher
    {
        private string _name;
        private string _address;
        private int _salary;

        public Teacher()
        {

        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value; 
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
            }
        }

        public int Salary
        {
            get { return _salary; }
            set
            {
                _salary = value;
            }
        }
    }
}
