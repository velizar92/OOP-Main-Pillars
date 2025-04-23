namespace Inheritance
{
    public class Person
    {

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public virtual string Work()
        {
            return "Person is working.";
        }

        public virtual string Walk()
        {
            return "Person is walking.";
        }
    }
}
