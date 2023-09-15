using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework_3.classes
{
    public enum GetMyGender
    {
        Male,
        Female
    }

    internal class User
    {

        private string firstName;

        public string FirstName {
            get {
                return firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The value cannot be empty or contain spaces.");
                }

                if (!char.IsUpper(value[0])) // Перевірка на велику букву
                {
                    throw new ArgumentException("The name must start with a capital letter.");
                }

                if (value.Length < 2) // Перевірка на мінімальну довжину імені
                {
                    throw new ArgumentException("The name must contain at least two letters.");
                }

                // Додаткові перевірки можуть бути додані тут
                firstName = value;
            }
        }

        public string LastName { get; set; }

        public int Age { get; private set; }

        protected GetMyGender gender { get; set; }

        public GetMyGender Gender {
            get => gender;
            set => gender = value;
        }

        private int birthYear { get; set; }
        public int BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; CalculateAge(); } // При встановленні року народження, перераховуємо вік
        }

        public User()
        {

        }

        public User(int age)
        {
            Age = age;
        }

        private void CalculateAge()
        {
            Age = DateTime.Now.Year - BirthYear;
        }

        public override string ToString()
        {
            string ageDescription = Age < 10 ? "I am a baby." : $"I am {Age} years old.";
            return $"Hi, my name is {FirstName} and last name {LastName}. {ageDescription} I am {Gender}.";
        }
    }
}
