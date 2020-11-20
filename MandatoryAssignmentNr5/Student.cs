using System;
using System.Text;

namespace MandatoryAssignmentNr5
{
    public class Student : SchoolMember
    {
        public Student(int id, string name, DateTime dob, int zipCode, string streetName, int addressNumber, string city, string country, DateTime startDate, DateTime endDate, string studyProgram) :  base(id, name, dob, zipCode, streetName, addressNumber, city, country)
        {
            StartDate = startDate;
            EndDate = endDate;
            StudyProgram = studyProgram;
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string StudyProgram { get; set; }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(base.ToString());
            str.AppendLine($"Start of education: {StartDate}");
            str.AppendLine($"Estimated End of Education: {EndDate}");
            str.AppendLine($"Study Program: {StudyProgram}");
            return str.ToString();
        }
    }
}
