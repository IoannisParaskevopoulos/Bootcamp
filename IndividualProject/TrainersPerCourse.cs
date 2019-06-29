using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    class TrainersPerCourse
    {
        List<Trainer> Trainers = new List<Trainer>();
        Course Course;


        public TrainersPerCourse(Course course, List<Trainer> trainers)
        {
            Course = course;
            Trainers = trainers;
        }

        public void Output()
        {
            Console.WriteLine(Course.title);
            Console.WriteLine("+--------------+--------------------+--------------+");

            foreach (var item in Trainers)
            {
                Console.WriteLine($"| {item.firstName,-12} | {item.lastName,-18} | {item.subject, -12} |");
            }
            Console.WriteLine("+--------------+--------------------+--------------+");
        }





    }
}
