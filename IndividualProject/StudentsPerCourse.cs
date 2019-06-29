using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    class StudentsPerCourse
    {
        List<Student> Students = new List<Student>();
        Course Course;
        

        public StudentsPerCourse(Course course, List<Student> student)
        {
            Course = course;
            Students = student;
        }

        public void Output()
        {
            Console.WriteLine(Course.title);
            Console.WriteLine("+--------------+--------------------+");
            foreach (var item in Students)
            {
                Console.WriteLine($"| {item.firstName, -12} | {item.lastName, -18} |");
                
            }
            Console.WriteLine("+--------------+--------------------+");
            
        }
    }
}
