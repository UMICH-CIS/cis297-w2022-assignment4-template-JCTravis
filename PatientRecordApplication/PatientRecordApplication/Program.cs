using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PatientRecordApplication
{
    ///<Summary>
    ///Jacob Travis
    ///CIS 297
    ///2-17-22
    ///Class patient instantiates the id, name and balance variables and has an addtofile function that writes
    ///the information given to the patientfile.txt
    ///</summary>
    class Patient
    {
        private int id;
        private string name;
        private decimal balance;

        public Patient(int id, string name, decimal balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }

        public void AddtoFile()
        {
            try
            {
                using (StreamWriter writeTo = File.AppendText("PatientFile.txt"))
                {
                writeTo.WriteLine("ID : " + this.id + ", Name : " + this.name + ", Balance " + this.balance, writeTo);
                }
            }

            catch(InputFailureException message failure)
            {
                Console.WriteLine("Can't find file name or input file contents");
            }
            
        }

    }

        ///<summary>
        ///Jacob Travis
        ///CIS 297
        ///2-17-22
        ///This class is the template for the user defined exception used in the patient class
        ///</summary>
    class InputFailureException : Exception
    {
        public InputFailureException(string message): base(message)
        {

        }
    }
        
    ///<summary>
    ///Jacob Travis
    ///CIS 297
    ///2-17-22
    ///This class reads from the patientfile.txt and outputs the contents of the file for the user to read;
    ///it loops through the lines of the file and outputs them all
    ///</summary>
    class ReadFiles : Patient
    {
        public counter;

        public Patient()
        {
            int counter = 0;
        }
        
        public void ReadfromFile()
        {
            foreach(string line in System.IO.File.ReadLines("PatientFile.txt"))
            {
                System.Console.ReadLine(Line);
                counter++;
            }
        }
            

    }


    ///<summary>
    ///Jacob Travis
    ///CIS 297
    ///2-17-22
    ///This class displays only the patient ID when prompted to by the user
    ///</summary>
    class DisplayData : Patient
    {
        public string identification;
        Console.ReadLine("Enter ID: ");

        identification = Convert.ToInt32(id);

        public void readPatientFile()
        {
            foreach(string line in System.IO.File.ReadLines("PatientFile.txt"))
            {
                try
                { 
                   if(line.Contains(id))

                    {
                         Console.WriteLine(line);
                    }
                }
                
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("either end of file or wrong item selected");
                }
                
            }
        }

    }

    ///<summary>
    ///Jacob Travis
    ///CIS 297
    ///2-17-22
    ///This class displays the balance only and makes sure that the balance is greater than 0
    ///</summary>
    class DisplayBalance : Patient
    {
        public string balance;
        Console.ReadLine("Enter balance: ");

        balance = Convert.ToDecimal(balance);

        public void ReadBalance()
        {
            foreach(string line in System.IO.File.ReadLines("PatientFile.txt"))
            {
                try
                { 
                   if(line.Contains(balance) && balance > 0)

                    {
                         Console.WriteLine(line);
                    }
                }
                
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("either end of file or wrong item selected");
                }
                
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
           int id;
           string name;
           decimal balance;

           Console.Write("Enter id for patient : ");
           id = int.Parse(Console.ReadLine());
           Console.Write("Enter name of patient : ");
           name = Console.ReadLine();
           Console.Write("Enter outstanding balance : ");

           balance = double.Parse(Console.ReadLine());
           Patient patient = new Patient(id, name, balance);
           patient.AddtoFile();
           Console.WriteLine("Record has been added to file.");
           Console.ReadKey();
           
           string choice;
           int counter;
           Console.ReadLine("Input choice: ");

           if (choice = "ReadFiles")
                {
                    ReadFiles read = new ReadFiles(counter);
                    read.ReadFromFile();
                }

           else if (choice = "DisplayData")
                {
                    DisplayData display = new DisplayData();
                    display.readPatientFile();
                }

           else if (choice = "DisplayBalance")
                {
                    DisplayBalance bal = new DisplayBalance();
                    bal.ReadBalance();
                }


        }
    }
}
