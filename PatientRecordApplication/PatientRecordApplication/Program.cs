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

    }

    class DisplayData
    {

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
