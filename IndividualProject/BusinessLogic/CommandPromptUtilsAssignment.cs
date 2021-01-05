using IndividualProject.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class CommandPromptUtilsAssignment: CommandPromptUtils //kanw inherit thn CommandPromptUtils gia na exw tis ask kai ta conversions mou
    {
        public Assignment GetAssignmentDetails(List<Course> courseslist)
        {
            Assignment assignment = new Assignment();
            assignment.Title = AskDetail("Give me the assignment's title: ");
            assignment.Description = AskDetail("Give me the assignment's description: ");
            assignment.DeadlineDateTime = ConvertToDateTime($"{AskDetail("Give me the assignment deadline date: ")}");
            assignment.OralMark = ConvertToFloat($"{AskDetail("Give me the oral mark of the assignment: ")}");
            assignment.TotalMark = ConvertToFloat($"{AskDetail("Give me the total mark of the assignment: ")}");
            List<string> titlechoicesofcourses = new List<string>();


            foreach (Course any_onecourseinlist in courseslist)
            {
                titlechoicesofcourses.Add(any_onecourseinlist.Title);
            }

            titlechoicesofcourses.Add("exit");

            for (int i = 1; i <= courseslist.Count; i++)
            {
                string courseorexit = AskDetail("In which course is this assignment placed? ", titlechoicesofcourses);


                if (courseorexit == "exit")
                {
                    break;
                }
                assignment.CoursesPerAssignment.Add(courseorexit);




            }




            return (assignment);
        }
        public void PrintAssignmentsList(List<Assignment> assignments)
        {
            foreach (var item in assignments)
            {
                Console.WriteLine(item);
                foreach (string course in item.CoursesPerAssignment)
                { Console.WriteLine(course); }
            }
        }

        public void PrintAssignmentsPerStudent(List<Assignment> assignments, List<Course> courses,List<Student> students)
        {
            
            
                foreach (Assignment ergasia in assignments)
                {
                Console.WriteLine(ergasia.Title);
                foreach (string mathhmathsergasias in ergasia.CoursesPerAssignment)
                {
                    foreach (Student mathhths in students)
                    {
                        foreach (Course mathhmamathhth in courses)
                        {
                            if (ergasia.Title == mathhmamathhth.Title)
                            {
                                Console.WriteLine(mathhths.FirstName+"  "+mathhths.LastName);
                            }
                        }
                    }
                        
                    }
                }
            
        }
    }
}
