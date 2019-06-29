using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    class Assignment
    {
        public string title { get; set; }
        public string description { get; set; } //set on a .txt file? too long for string?
        public DateTime subDateTime { get; set; }
        public int oralMark { get; set; }
        public int totalMark { get; set; }



        public Assignment()
        {

        }

        public Assignment(string titl, string descr, DateTime subDate, int orMark, int tMark)
        {
            title = titl;
            description = descr;
            subDateTime = subDate;
            oralMark = orMark;
            totalMark = tMark;

        }

        public void Output()
        {
            Console.WriteLine($"| {title, -15} | {description, -20}| {subDateTime.ToString("dd/MM/yyyy"), -20} |{oralMark, -12} | {totalMark, -12} |");
        }
    }
}
