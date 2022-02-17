using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PatientRecordApplication
{

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
            using (StreamWriter writeTo = File.AppendText("PatientFile.txt"))
            {
                writeTo.WriteLine("ID : " + this.id + ", Name : " + this.name + ", Balance " + this.balance, writeTo);
            }
        }

    }

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

    class DisplayBalance : Patient
    {
        public string balance;
        Console.ReadLine("Enter balance: ");

        balance = Convert.ToDecimal(balance);

        public void readPatientFile()
        {
            foreach(string line in System.IO.File.ReadLines("PatientFile.txt"))
            {
                try
                { 
                   if(line.Contains(balance))

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

        }
    }
}
