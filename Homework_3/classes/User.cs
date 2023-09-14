using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.classes
{
    public enum GenderType
    {
        Male,
        Female
    }


    internal class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; private set; }
        public GenderType Gender { get; set; }
        public int BirthYear { get; set; }

        public string result { get; set; }

        public User(string name, string lastName, GenderType gender, int birthYear)
        {
            Name = name;
            Gender = gender;
            LastName = lastName;
            BirthYear = birthYear;
            Age = CalculateAge();
        }

        private int CalculateAge()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - BirthYear;
        }

        public override string ToString()
        {
            if (Age >= 10)
            {
                result = $"Hi, my name is {Name} and last name {LastName}. I am {Age} years old and {Gender}.";
            }
            else
            {
                result = $"Hi, my name is {Name} and last name {LastName}. I am a baby years old and {Gender}.";
            }

            return result;
        }
    }
}
