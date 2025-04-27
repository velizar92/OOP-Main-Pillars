namespace Polymorphism
{
    public class Administrator : Member
    {
        public Administrator(string firstName, string lastName, int age) 
            : base(firstName, lastName, age)
        {
        }

        public override string Attend()
        {
            return "Administrator is attending";
        }

        public override string Report()
        {
            return "Administrator is reporting";
        }

        public override string Schedule()
        {
            return "Administrator is scheduling";
        }
    }
}
