using System;
using System.Collections.Generic;

namespace MandatoryAssignmentNr5
{
    public class Processor
    {

        static List<SchoolMember> schoolData = new List<SchoolMember>();

        // TODO: create a method storing person into generic (one) list 
        public int menuOption()
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1) View database");
            Console.WriteLine("2) Add record");
            Console.WriteLine("3) Quit");

            Console.Write("Press number of your choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        // TODO: add list as a parametr and add the object into the list
        public void createDummyRecordStudent()
        {
            string birthdate = "17/5/1996";
            DateTime oBirthdate = DateTime.ParseExact(birthdate, "d/M/yyyy", null);
            string startDate = "1/9/2020";
            DateTime oStartDate = DateTime.ParseExact(startDate, "d/M/yyyy", null);
            string endDate = "30/6/2020";
            DateTime oEndDate = DateTime.ParseExact(endDate, "d/M/yyyy", null);

            Student student = new Student(1, "Adam Borovec", oBirthdate, 2300, "Gyldenrisvej", 64, "København", "Denmark", oStartDate, oEndDate, "Data Science");

            schoolData.Add(student);

        }

        // TODO: add list as a parametr and add the object into the list
        public void createDummyRecordStaff()
        {
            string birthdate = "17/5/1973";
            DateTime oBirthdate = DateTime.ParseExact(birthdate, "d/M/yyyy", null);
            string startDate = "1/9/2015";
            DateTime oStartDate = DateTime.ParseExact(startDate, "d/M/yyyy", null);

            AdmStaff administrative = new AdmStaff(1, "Abid Husain", oBirthdate, 2300, "Amagerbrogade", 512, "København", "Denmark","Digitalization", "Head of Department", oStartDate);

            schoolData.Add(administrative);

        }

        // method adding  
        public void createDummyRecordManagement()
        {
            string birthdate = "15/12/1970";
            DateTime oBirthdate = DateTime.ParseExact(birthdate, "d/M/yyyy", null);
            string startDate = "1/12/2000";
            DateTime oStartDate = DateTime.ParseExact(startDate, "d/M/yyyy", null);

            TopManagement topMan = new TopManagement(1, "Mads Forselius", oBirthdate, 2300, "Roskildevej", 12, "Roskilde", "Denmark", "Business Management", "Rektor", oStartDate, 25, 3);

            schoolData.Add(topMan);
        }

        // method getting data from console user and storing them to a list 
        public void userInput(List<SchoolMember> data)
        {
            Console.WriteLine("Which data record you would like to save? (1 = student, 2 = administrative, 3 = top management)");
            int recordType = int.Parse(Console.ReadLine());

            Console.WriteLine("Please provide your information about");
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Full name: ");
            string name = Console.ReadLine();

            Console.Write("Date of Birth (DD/MM/YYYY format, eg. 25/2/1990): ");
            DateTime birthdate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", null);

            Console.Write("Street Name: ");
            string streetName = Console.ReadLine();

            Console.Write("Address number: ");
            int streetNr = int.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.Write("Zip Code: ");
            int zip = int.Parse(Console.ReadLine());

            Console.Write("Country: ");
            string country = Console.ReadLine();

            switch (recordType)
            {
                case 1:
                    Console.Write("Start of the studies (DD/MM/YYYY format, eg. 25/2/2019): ");
                    DateTime studyStart = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", null);

                    Console.Write("Estimated end of the studies (DD/MM/YYYY format, eg. 25/6/2021): ");
                    DateTime studyEnd = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", null);

                    Console.Write("Name of the study program: ");
                    string studyProgram = Console.ReadLine();

                    Student newStudent = new Student(id, name, birthdate, zip, streetName, streetNr, city, country, studyStart, studyEnd, studyProgram);
                    data.Add(newStudent);
                    Console.WriteLine($"Student '{name}' added to the database\n");
                    break;

                case 2:
                    Console.Write("Department: ");
                    string admDepartment = Console.ReadLine();

                    Console.Write("Role: ");
                    string admRole = Console.ReadLine();

                    Console.Write("Start of the employment (DD/MM/YYYY format, eg. 12/6/1997): ");
                    DateTime emploStart = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", null);

                    AdmStaff newAdministrative = new AdmStaff(id, name, birthdate, zip, streetName, streetNr, city, country, admDepartment, admRole, emploStart);
                    data.Add(newAdministrative);
                    Console.WriteLine($"Administrative staff '{name}' added to the database\n");
                    break;

                case 3:
                    Console.Write("Department: ");
                    string mngDepartment = Console.ReadLine();

                    Console.Write("Role: ");
                    string mngRole = Console.ReadLine();

                    Console.Write("Start of the employment (DD/MM/YYYY format, eg. 12/6/1997): ");
                    DateTime mngStart = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", null);

                    Console.Write("Years of experience in management: ");
                    int experience = int.Parse(Console.ReadLine());

                    Console.Write("Area of management (1 = Research, 2 = Teaching, 3 = Organizer): ");
                    int area = int.Parse(Console.ReadLine());

                    TopManagement newMng = new TopManagement(id, name, birthdate, zip, streetName, streetNr, city, country, mngDepartment, mngRole, mngStart, experience, area);
                    data.Add(newMng);
                    Console.WriteLine($"Top manager '{name}' added to the database\n");
                    break;


                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            Process();
        }

        public void ShowRecords(List<SchoolMember> data)
        {
            foreach (object record in data)
            {
                Console.WriteLine(record);
            }

            Process();
        }

            // method returning the output
            public void Process()
        {
            
            try
            {
                int option = menuOption();
                switch (option)
                    {
                        case 1:
                            ShowRecords(schoolData);
                            break;

                        case 2:
                            userInput(schoolData);
                            break;
                        case 3:
                            System.Environment.Exit(1);
                            break;
                    }
            }
            
            catch(System.FormatException)
            {
                Console.WriteLine($"ERROR: Please use correct data format on input\n");
                Process();
            }

            catch (Exception)

            {
                Console.WriteLine($"Error occured, please try again");
                Process();
            }


        }
    }
}
