using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    public static class Repository
    {
        public static void PrintSyntheticData()
        {
            //Objects:

            Trainer t1 = new Trainer("Hector", "Gkatsos", "C#");
            Trainer t2 = new Trainer("Argiris", "Pagidas", "C#");
            Trainer t3 = new Trainer("Athanasios", "Xristopoulos", "Mathematics");
            Trainer t4 = new Trainer("Bill", "Gates", "MS WINDOWS");
            Trainer t5 = new Trainer("Steve", "Jobs", "Swift");
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Course c1 = new Course("Basics - Classes", "C#", "Part-time", new DateTime(2019, 5, 15), new DateTime(2019, 6, 15));
            Course c2 = new Course("Basics - Delegates", "C#", "Full-time", new DateTime(2019, 5, 15), new DateTime(2019, 5, 30));
            Course c3 = new Course("Basics - Variables", "Java", "Part-time", new DateTime(2019, 5, 15), new DateTime(2019, 6, 17));
            Course c4 = new Course("Basics - Inheritance", "Java", "Full-time", new DateTime(2019, 5, 15), new DateTime(2019, 5, 25));
            Course c5 = new Course("Lamdas and Linq", "C#", "Part-time", new DateTime(2019, 6, 16), new DateTime(2019, 7, 30));
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Student s1 = new Student("Antonios", "Stavrinos", new DateTime(1990, 4, 21), 2500);
            Student s2 = new Student("Mary", "Kovani", new DateTime(1990, 5, 22), 2500);
            Student s3 = new Student("Panos", "Benardis", new DateTime(1992, 7, 17), 2500);
            Student s4 = new Student("Angela", "Papadaki", new DateTime(1995, 2, 7), 2500);
            Student s5 = new Student("Giannis", "Lelegiannis", new DateTime(2000, 1, 1), 2500);
            /////////////////////////////////////////////////////////////////////////////////////////
            Assignment a1 = new Assignment("Project1", "part a", new DateTime(2019, 6, 21), 90, 160);
            Assignment a2 = new Assignment("Project1", "part b", new DateTime(2019, 6, 30), 95, 175);
            Assignment a3 = new Assignment("Project1", "part C", new DateTime(2019, 7, 27), 75, 145);
            Assignment a4 = new Assignment("TeamProject1", "part a", new DateTime(2019, 9, 7), 70, 140);
            Assignment a5 = new Assignment("TeamProject1", "part b", new DateTime(2019, 9, 15), 80, 160);
            Assignment a6 = new Assignment("TeamProject1", "part c", new DateTime(2019, 9, 29), 90, 180);
            Assignment a7 = new Assignment("FinalProject", "parts a - d", new DateTime(2019, 10, 29), 95, 190);
            ///////////////////////////////////////////////////////////////////////////////////////////////////

            //Lists:

            List<Trainer> trainers = new List<Trainer>();
            List<Course> courses = new List<Course>();
            List<Student> students = new List<Student>();
            List<Assignment> assignments = new List<Assignment>();
            ///////////////////////////////////////////////////////

            //Filling the lists:

            trainers.Add(t1);
            trainers.Add(t2);
            trainers.Add(t3);
            trainers.Add(t4);
            trainers.Add(t5);

            courses.Add(c1);
            courses.Add(c2);
            courses.Add(c3);
            courses.Add(c4);
            courses.Add(c5);

            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);

            assignments.Add(a1);
            assignments.Add(a2);
            assignments.Add(a3);
            assignments.Add(a4);
            assignments.Add(a5);

            ////////////////////

            //Printing contents of the lists:

            Console.WriteLine("List of Trainers:\n ");
            Console.WriteLine($"+---{"First Name"}---+---{"Last Name"}----+----{"Subject"}-----+");

            foreach (var item in trainers)
            {
                item.Outpout();
            }

            Console.WriteLine("+----------------+----------------+----------------+");
            Console.WriteLine("\n");
            Console.WriteLine();





            Console.WriteLine("List of Courses:\n ");
            Console.WriteLine($"+----{"Title"}-------------+-{"Stream"}--+---{"Type"}---+-{"Start Date"}--+---{"End Date"}---+");

            foreach (var item in courses)
            {
                item.Output();
            }

            Console.WriteLine("+----------------------+---------+----------+-------------+--------------+");
            Console.WriteLine("\n");
            Console.WriteLine();





            Console.WriteLine("List of Studens:\n ");
            Console.WriteLine($"+-----{"First Name"}----+------{"Last Name"}----+--{"Date of Birth"}--+--{"Tuition Fees"}--+");

            foreach (var item in students)
            {
                item.Output();
            }

            Console.WriteLine("+-------------------+-------------------+-----------------+----------------+");
            Console.WriteLine("\n");
            Console.WriteLine();






            Console.WriteLine("List of Assignments:\n ");
            Console.WriteLine($"+----{"Title"}-----+--+-{"Description"}---------+---{"Submission Date"}----+--{"Oral Mark"}--+--{"Total Mark"}--+");

            foreach (var item in assignments)
            {

                item.Output();
            }

            Console.WriteLine("+-----------------+---------------------+----------------------+-------------+--------------+");
            Console.WriteLine("\n");
            Console.WriteLine();




            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine();
            Console.WriteLine();



            //Students Per Course:

            Console.WriteLine("Students per Course: " + "\n");

            List<StudentsPerCourse> studentsPC = new List<StudentsPerCourse>();

            StudentsPerCourse SPC1 = new StudentsPerCourse(c1, students);
            StudentsPerCourse SPC2 = new StudentsPerCourse(c5, students);

            studentsPC.Add(SPC1);
            studentsPC.Add(SPC2);

            foreach (var item in studentsPC)
            {
                item.Output();
            }


            Console.WriteLine();
            Console.WriteLine();




            //Trainers Per Course:

            Console.WriteLine("Trainers per Course: " + "\n");

            List<TrainersPerCourse> trainersPC = new List<TrainersPerCourse>();

            TrainersPerCourse TPC1 = new TrainersPerCourse(c2, trainers);
            TrainersPerCourse TPC2 = new TrainersPerCourse(c5, trainers);

            trainersPC.Add(TPC1);
            trainersPC.Add(TPC2);

            foreach (var item in trainersPC)
            {
                item.Output();
            }


            Console.WriteLine();
            Console.WriteLine();





            //Assignments Per Course:

            Console.WriteLine("Assignments per Course: " + "\n");

            List<AssignmentsPerCourse> assignmentsPC = new List<AssignmentsPerCourse>();

            AssignmentsPerCourse APC1 = new AssignmentsPerCourse(c1, assignments);
            AssignmentsPerCourse APC2 = new AssignmentsPerCourse(c3, assignments);

            assignmentsPC.Add(APC1);
            assignmentsPC.Add(APC2);

            foreach (var item in assignmentsPC)
            {
                item.Output();
            }
        }
    }
}
