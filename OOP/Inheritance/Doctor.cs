namespace Inheritance
{
    /*
     * Because we inherit Person class, we inherit all logic there, so we have code reuse.
     * That means all properties and methods in the Person class are available for this class as well.
     */

    public class Doctor : Person
    {
        public Doctor(string firstName, string lastName, int age, string specialty) 
            : base(firstName, lastName, age)
        {
            Specialty = specialty;
        }

        public string Specialty { get; set; }

        public string Heal()
        {
            return "Doctor is healing.";
        }
    }
}
