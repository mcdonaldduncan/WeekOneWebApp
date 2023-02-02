namespace WeekOneWebApp.Models
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }
        public int YearOfBirth { get; set; }

        public UserModel()
        {

        }

        public UserModel(string _firstName, string _lastName, int _age, string _occupation, int _yearOfBirth)
        {
            FirstName = _firstName;
            LastName = _lastName;
            Age = _age;
            Occupation = _occupation;
            YearOfBirth = _yearOfBirth;
        }

    }
}
