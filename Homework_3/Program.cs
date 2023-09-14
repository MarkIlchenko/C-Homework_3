using Homework_3.classes;

//  Console.WriteLine("Hello, created project!");

//  User user1 = new User("Mark", "Ilchenko", GenderType.Male, 2003);

static void MyMethod(string fname)
{
    Console.Write($"Enter your {fname}: ");
}

MyMethod("userName");
string userName = Console.ReadLine();

MyMethod("lastName");
string lastName = Console.ReadLine();

MyMethod("gender");
string genderString = Console.ReadLine();
GenderType gender = (GenderType)Enum.Parse(typeof(GenderType), genderString, true);

MyMethod("dateOfBirth");
string dateOfBirthString = Console.ReadLine();
int dateOfBirth = int.Parse(dateOfBirthString);


User user1 = new User(userName, lastName, gender, dateOfBirth);

Console.WriteLine(user1.ToString());