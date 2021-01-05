using IndividualProject.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class CommandPromptUtilsCourse : CommandPromptUtils //kanw inherit thn CommandPromptUtils gia na exw tis ask kai ta conversions mou
    {
        public Course GetCourseDetails()
        {
            //orizw tis listes me epiloges gia to course, h ask tha tis xrhsimopoihsei gia na epileksei o xrhsths auto pou thelei
            List<string> streams = new List<string>() { "C#", "Java", "Python", "PHP" };
            List<string> type = new List<string>() { "Full Time", "Part Time","Hybrid"};
            List<string> startdate = new List<string>() { "16/10/2020" , "16/01/2021" };
            List<string> enddate = new List<string>() { "16/01/2021", "16/04/2021" };


            Course course = new Course();
            course.Stream = AskDetail("Please, choose the stream of the course: ", streams);
            course.Type = AskDetail("Please, choose the type of the course", type);
            course.StartDate = ConvertToDateTime($"{AskDetail("Please, insert the start date of the course: ")}");
            course.EndDate = ConvertToDateTime($"{AskDetail("Please, insert the end date of the course: ")}");

            course.Title = course.Stream + course.Type + course.StartDate + course.EndDate;
                
            Console.WriteLine("Ok, the title of the course is : " + course.Title);
            
            return (course);
        }
        public void PrintCoursesList(List<Course> courses)
        {
            foreach (var item in courses)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintStudentsInACourse(List<Student> students, List<Course> courses)
        {
            foreach (Course mathhma in courses)
            {
                Console.WriteLine(mathhma.Title);
                foreach (Student mathhths in students)
                {
                    foreach (string mathhmatoumathhth in mathhths.CoursesPerStudent)
                    {
                        if (mathhma.Title == mathhmatoumathhth)
                        {
                            Console.WriteLine(mathhths.FirstName + "  " + mathhths.LastName);
                        }
                    }
                }
            }
        }

        public void PrintTrainersInACourse(List<Trainer> trainers, List<Course> courses)
        {
            foreach (Course mathhma in courses)
            {
                Console.WriteLine(mathhma.Title);
                foreach (Trainer daskalos in trainers)
                {
                    foreach (string mathhmatoudaskalou in daskalos.CoursesPerTrainer)
                    {
                        if (mathhma.Title == mathhmatoudaskalou)
                        {
                            Console.WriteLine(daskalos.FirstName + "  " + daskalos.LastName);
                        }
                    }
                }
            }
        }
        public void PrintAssignmentsInACourse(List<Assignment> assignments, List<Course> courses)
        {
            foreach (Course mathhma in courses)
            {
                Console.WriteLine(mathhma.Title);
                foreach (Assignment ergasia in assignments)
                {
                    foreach (string mathhmathsergasias in ergasia.CoursesPerAssignment)
                    {
                        if (mathhma.Title == mathhmathsergasias)
                        {
                            Console.WriteLine(ergasia.Title);
                        }
                    }
                }
            }
        }
    }
}
