﻿using System;
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

            CommandPromptUtilsTrainer cpUtils1 = new CommandPromptUtilsTrainer();
            CommandPromptUtilsStudent cpUtils2 = new CommandPromptUtilsStudent();
            CommandPromptUtilsCourse cpUtils3 = new CommandPromptUtilsCourse();
            CommandPromptUtilsAssignment cpUtils4 = new CommandPromptUtilsAssignment();
            CommandPromptUtils cpUtils0 = new CommandPromptUtils();

            //prwta ftiaxnw ta courses mou
            List<Course> courses = new List<Course>();
            //Ask number of courses
            Console.WriteLine("Give me number of courses");
            int z = cpUtils0.ConvertToInt(Console.ReadLine());
            //Loop for each course
            for (int i = 1; i <= z; i++)
            {
                Console.WriteLine($"*****Course number:{i}*****");
                courses.Add(cpUtils3.GetCourseDetails());
            }
            cpUtils3.PrintCoursesList(courses);


            List<Trainer> trainers = new List<Trainer>();
            //Ask number of trainers
            Console.WriteLine("Give me number of trainers");
            int x = cpUtils0.ConvertToInt(Console.ReadLine());
            //Loop for each trainer 
            // Kalw thn convert thn dikia mou apo to vasiko CommandPromptUtils gia na apofugw exception
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine($"*****Teacher number:{i}*****");
                trainers.Add(cpUtils1.GetTrainerDetails(courses));

            }

            cpUtils1.PrintTrainersList(trainers);


            List<Student> students = new List<Student>();
            //Ask number of students
            Console.WriteLine("Give me number of students");
            int y = cpUtils0.ConvertToInt(Console.ReadLine());
            //Loop for each student
            for (int i = 1; i <= y; i++)
            {
                Console.WriteLine($"*****Student number:{i}*****");
                students.Add(cpUtils2.GetStudentDetails(courses));
            }
            cpUtils2.PrintStudentsList(students);


            List<Assignment> assignments = new List<Assignment>();
            //Ask number of assignments
            Console.WriteLine("Give me number of assignments");
            int q = cpUtils0.ConvertToInt(Console.ReadLine());
            //Loop for each assignment
            for (int i = 1; i <= q; i++)
            {
                Console.WriteLine($"*****Assignment number:{i}*****");
                assignments.Add(cpUtils4.GetAssignmentDetails(courses));
            }
            cpUtils4.PrintAssignmentsList(assignments);

            cpUtils3.PrintStudentsInACourse(students, courses);
            cpUtils3.PrintTrainersInACourse(trainers, courses);
            cpUtils3.PrintAssignmentsInACourse(assignments, courses);
            cpUtils4.PrintAssignmentsPerStudent(assignments, courses ,students);


        }

       










    }
}
