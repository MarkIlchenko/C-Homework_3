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
        // Дефолтнi пропертiс.
        public string Name { get; set; }
        public string LastName { get; set; }
        private int Age { get; }
        public GenderType Gender { get; set; }

        // Тут я вирiшив спробувати взяти вiк користувача за його датою народження.
        public int BirthYear { get; set; }

        // Тут я стукаюсь до нашиз змiнних, через Program.cs я беру вiд користувача даннi, та ставлю їх сюди.
        public User(string name, string lastName, GenderType gender, int birthYear)
        {
            Name = name;
            Gender = gender;
            LastName = lastName;
            BirthYear = birthYear;
            Age = CalculateAge();
        }

        // Цей метод допомагає вирахувати нинішній вік користувача за його датою народження.
        private int CalculateAge()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - BirthYear;
        }

        // Тут я збираюсь вивести всi данні про користувача.
        private string GetIntroductionMessage()
        {
            return Age >= 10
                ? $"Hi, my name is {Name} and last name {LastName}. I am {Age} years old and {Gender}."
                : "I am a baby.";
        }

        public override string ToString()
        {
            return GetIntroductionMessage();
        }
    }
}
