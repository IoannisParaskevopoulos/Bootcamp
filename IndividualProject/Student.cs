using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public int tuitionFees { get; set; }

        public Student(string fn, string ln, DateTime dob, int tuit)
        {
            firstName = fn;
            lastName = ln;
            dateOfBirth = dob;
            tuitionFees = tuit;
        }

        public void Output()
        {
            Console.WriteLine($"| {firstName, -17} | {lastName, -17} | {dateOfBirth.ToString("dd/MM/yyyy"), -15} | {tuitionFees, -14} |");
        }
    }


    
}
