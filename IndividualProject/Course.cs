using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    class Course
    {
        public string title { get; set; }
        public string stream { get; set; } //part or full time...Perhaps enum better?
        public string type { get; set; } //C# or Java... enum too?
        public DateTime start_date { get; set; } //Needs DateTime
        public DateTime end_date { get; set; } //DateTime or a better alternative?


        public Course()
        {
            
        }

        public Course(string titl, string strea, string typ, DateTime startd, DateTime endd)
        {
            title = titl;
            stream = strea;
            type = typ;
            start_date = startd;
            end_date = endd;
        }

        public void Output()
        {
            Console.WriteLine($"| {title, -20} | {stream, -7} |{type, -5} |{start_date.ToString("dd/MM/yyyy"), -12} | {end_date.ToString("dd/MM/yyyy"), -12} |");
        }


    }
}
