﻿namespace Inheritance
{
    /*
      * Because we inherit Member class, we inherit all logic there, so we have code reuse.
      * That means all properties and methods in the Member class are available for this class as well.
     */

    public class Lector : Member
    {
        public Lector(string firstName, string lastName, int age, int lectorId, string address) 
            : base(firstName, lastName, age)
        {
            LectorId = lectorId;
            Address = address;
        }

        public int LectorId { get; set; }

        public string Address { get; set; }

        public string Teach()
        {
            return "Lector is teaching";
        }
    }
}
