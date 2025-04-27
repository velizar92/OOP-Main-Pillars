namespace Inheritance
{
    /*
      * Because we inherit Member class, we inherit all logic there, so we have code reuse.
      * That means all properties and methods in the Member class are available for this class as well.
     */

    public class Student : Member
    {
        public Student(string firstName, string lastName, int age, int studentId) 
            : base(firstName, lastName, age)
        {
            StudentId = studentId;
            AssignedCourses = new List<string>();
        }

        public int StudentId { get; set; }
        public IEnumerable<string> AssignedCourses { get; set; }

        public string Learn()
        {
            return "Student is learning.";
        }
    }
}
