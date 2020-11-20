using System;

namespace MandatoryAssignmentNr5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*** Welcome to school database system ***");
            Console.WriteLine("Here you can list or upload staff and students");

            


            Processor p = new Processor();

            // fill dummy variables
            p.createDummyRecordManagement();
            p.createDummyRecordStaff();
            p.createDummyRecordStudent();

            
            p.Process();
        }
    }
}
