namespace Inheritance
{
    public class Member
    {
        public Member(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public virtual string ReportMemberInfo()
        {
            return $"First name: {FirstName}, Last name: {LastName}, Age: {Age}.";
        }            
    }
}
