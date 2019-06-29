using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    class Trainer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string subject { get; set; }

        public Trainer()
        {
            //Def constructor. Should it print something? Is it even needed???
        }

        public Trainer(string fn, string ln, string sub)
        {
            firstName = fn;
            lastName = ln;
            subject = sub;
        }

        public void Outpout()
        {
            Console.WriteLine($"| {firstName, -14} | {lastName, -14} | {subject, -14} |");
        }
    }
}
