using System;
using System.Text;

namespace MandatoryAssignmentNr5
{
    public class SchoolMember
    {
        
        public SchoolMember(int id, string name, DateTime dob, int zipCode, string streetName, int addressNumber, string city, string country)
        {
            Id = id;
            Name = name;
            DoB = dob;
            ZipCode = zipCode;
            StreetName = streetName;
            AddressNumber = addressNumber;
            City = city;
            Country = country;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public int ZipCode { get; set; }
        public string StreetName { get; set; }
        public int AddressNumber { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            StringBuilder textOutput = new StringBuilder();
            textOutput.AppendLine("\n----------------------------------------------");
            textOutput.AppendLine($"Id: {Id}");
            textOutput.AppendLine($"Name: {Name}");
            textOutput.AppendLine($"Birth Date: {DoB}");
            textOutput.AppendLine($"Address: {StreetName} {AddressNumber}, {ZipCode} {City}, {Country}");

            return textOutput.ToString();
        }
    }
}
