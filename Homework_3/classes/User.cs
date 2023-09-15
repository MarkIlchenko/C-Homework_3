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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; private set; }
        protected GetMyGender gender { get; set; }
        public GetMyGender Gender {
            get => gender;
            set => gender = value;
        }

        public User()
        {

        }

        public User(int age)
        {
            Age = age;
        }
    }
}
