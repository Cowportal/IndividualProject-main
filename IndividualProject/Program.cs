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
            trainers.Add(cpUtils.GetTrainerDetails());
            cpUtils.PrintTrainersList(trainers);

            List<Student> students = new List<Student>();
            students.Add(cpUtils.GetStudentDetails());
            cpUtils.PrintStudentsList(students);

           

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
