using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;
using IndividualProject.BusinessLogic;

namespace IndividualProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandPromptUtils cpUtils = new CommandPromptUtils();
            List<Trainer> trainers = new List<Trainer>();
            //Ask number of trainers
            Console.WriteLine("Give me number of trainers");
            int x = Convert.ToInt32(Console.ReadLine());
            //Loop for each trainer
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine("*****Teacher number: "+i+"*****");
                trainers.Add(cpUtils.GetTrainerDetails());
                
            }

            cpUtils.PrintTrainersList(trainers);

            List<Student> students = new List<Student>();
            //Ask number of students
            Console.WriteLine("Give me number of students");
            int y = Convert.ToInt32(Console.ReadLine());
            //Loop for each student
            for (int i = 1; i <= y; i++)
            {
                Console.WriteLine("*****Student number: " + i + "*****");
                students.Add(cpUtils.GetStudentDetails());
            }
            cpUtils.PrintStudentsList(students);

            List<Course> courses = new List<Course>();
            //Ask number of courses
            Console.WriteLine("Give me number of courses");
            int z = Convert.ToInt32(Console.ReadLine());
            //Loop for each course
            for (int i = 1; i <= z; i++)
            {
                Console.WriteLine("*****course number: " + i + "*****");
                courses.Add(cpUtils.GetCourseDetails());
            }
            cpUtils.PrintCoursesList(courses);

        }

        /*
         * 
         * modelopoihsh
         * List<Student>
        List <Trainer>
        List <Assignment>
        List<Course>
        
        CB12
        Full Time / Part Time
        C# / Java / Javascript

        CB12 Java Full Time
        CB12 
        
        
        
        
        
        */

      







        //--------------------------------------------------
        //Trainer trainer =  cpUtils.GetTrainerDetails();
        //Console.WriteLine(trainer);
        //Trainer trainer2 = cpUtils.GetTrainerDetails();
        //Console.WriteLine(trainer2);
        //trainers.Add(cpUtils.GetTrainerDetails());
        //trainers.Add(cpUtils.GetTrainerDetails());
        //--------------------------------------------------



        // Create appropriate methods in order to ask 
        // from the user data for the four main classes



    }
}
