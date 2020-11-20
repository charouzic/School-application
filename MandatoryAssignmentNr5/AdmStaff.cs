using System;
using System.Text;

namespace MandatoryAssignmentNr5
{
    public class AdmStaff : SchoolMember
    {
        public AdmStaff(int id, string name, DateTime dob, int zipCode, string streetName, int addressNumber, string city, string country, string department, string role, DateTime startDate) : base (id, name, dob, zipCode, streetName, addressNumber, city, country)
        {
            Department = department;
            Role = role;
            StartDate = startDate;
        }
        public string Department { get; set; }
        public string Role { get; set; }
        public DateTime StartDate { get; set; }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(base.ToString());
            str.AppendLine($"Department: {Department}");
            str.AppendLine($"Role: {Role}");
            str.AppendLine($"Start of Emplyment: {StartDate}");
            return str.ToString();
        }
    }
}
