using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                w.WriteLine("ID : " + this.id + ", Name : " + this.name + ", Balance " + this.balance, writeTo);
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
        Console.WriteLine("Enter ID");


    }

    class DisplayBalance
    {

    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
