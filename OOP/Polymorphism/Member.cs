namespace Polymorphism
{
    /*Because "Member" class is marked as "abstract" it cannot be instantiated.*/
    public abstract class Member
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

        /* All these abstract methods MUST be overridden/implemented from the derived
         * classes.
        */

        public abstract string Attend();

        public abstract string Schedule();

        public abstract string Report();

        /*The derived classes have a choice to override this virtual method, or to do
         *not. If they do not override it, they will use the base implementation here. 
        */

        public virtual string GetMemberInfo()
        {
            return $"First name: {FirstName}, Last name: {LastName} and Age: {Age}.";
        }
    }
}
