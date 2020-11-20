using System;
using System.Text;

namespace MandatoryAssignmentNr5
{
    public class TopManagement : SchoolMember
    {
        public TopManagement(int id, string name, DateTime dob, int zipCode, string streetName, int addressNumber, string city, string country, string department, string role, DateTime startDate, int yearsOfExperience, int managementArea) : base(id, name, dob, zipCode, streetName, addressNumber, city, country)
        {
            Department = department;
            Role = role;
            StartDate = startDate;
            YearsOfExperience = yearsOfExperience;
            ManagementArea = managementArea;
        }

        public string Department { get; set; }
        public string Role { get; set; }
        public DateTime StartDate { get; set; }
        public int YearsOfExperience { get; set; }

        public int ManagementArea { get; set; } // area = research, teaching, organizet

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(base.ToString());
            str.AppendLine($"Department: {Department}");
            str.AppendLine($"Role: {Role}");
            str.AppendLine($"Start of Emplyment: {StartDate}");
            str.AppendLine($"Years of Experience: {YearsOfExperience}");
            switch (ManagementArea)
            {
                case 1:
                    str.AppendLine($"Management Area: Research");
                    break;
                case 2:
                    str.AppendLine($"Management Area: Teaching");
                    break;
                case 3:
                    str.AppendLine($"Management Area: Organizer");
                    break;
            }
            return str.ToString();
        }
    }
}
