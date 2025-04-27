namespace Polymorphism
{
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

        public override string Attend()
        {
            return "Student is attending";
        }

        public override string Report()
        {
            return "Student is reporting";
        }

        public override string Schedule()
        {
            return "Student is scheduling";
        }
    }
}
