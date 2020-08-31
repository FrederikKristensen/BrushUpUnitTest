using System;

namespace BrushUpUnitTest
{
    public enum Gendertype
    {
        Cisgender, Transgender
    }

    public class Student
    {
        private string _name;
        private string _address;
        private int _semester;

        public Student(string name, string address, int semester, Gendertype gender)
        {
            Name = name;
            Address = address;
            Semester = semester;
            Gender = gender;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == null) throw new ArgumentNullException("name", "Remeber to enter name!");
                if (value.Length < 2) throw new ArgumentOutOfRangeException("The name is too short");
                _name = value;
            }
        }

        public string Address 
        {
            get { return _address; }
            set 
            {
                if (value == null) throw new ArgumentNullException("Address", "Remeber to enter a Address");
                _address = value;
            } 
        }

        public int Semester
        {
            get { return _semester; }
            set
            {
                if (value < 1) throw new ArgumentOutOfRangeException("Semester is too low");
                if (value > 8) throw new ArgumentOutOfRangeException("Semester is too high");
                _semester = value;
            }
        }

        public Gendertype Gender { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
