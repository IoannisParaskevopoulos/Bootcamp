using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    class AssignmentsPerCourse
    {
        List<Assignment> Assignments = new List<Assignment>();
        Course Course;

        public AssignmentsPerCourse(Course course, List<Assignment> assignments)
        {
            Course = course;
            Assignments = assignments;
        }

        public void Output()
        {
            Console.WriteLine(Course.title);
            Console.WriteLine("+-----------------+---------------------+----------------+");

            foreach (var item in Assignments)
            {
                Console.WriteLine($"| {item.title,-15} | {item.description,-20}| {item.subDateTime.ToString("dd/MM/yyyy"),-14} |");
            }
            Console.WriteLine("+-----------------+---------------------+----------------+");
        }



    }
}
