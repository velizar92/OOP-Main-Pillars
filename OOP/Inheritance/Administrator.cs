namespace Inheritance
{
    /*
     * Because we inherit Member class, we inherit all logic there, so we have code reuse.
     * That means all properties and methods in the Member class are available for this class as well.
    */

    public class Administrator : Member
    {
        public Administrator(string firstName, string lastName, int age) 
            : base(firstName, lastName, age)
        {
            
        }

        public string ScheduleMeetings()
        {
            return "Scheduling of meetings";
        }
    }
}
