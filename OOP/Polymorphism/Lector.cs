using System.Text;

namespace Polymorphism
{
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

        public override string Attend()
        {
            return "Lector is attending";
        }

        public override string Report()
        {
            return "Lector is reporting";
        }

        public override string Schedule()
        {
            return "Lector is scheduling";
        }

        public override string GetMemberInfo()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.GetMemberInfo());
            stringBuilder.AppendLine($"The Address: {Address}.");

            return stringBuilder.ToString();
        }
    }
}
