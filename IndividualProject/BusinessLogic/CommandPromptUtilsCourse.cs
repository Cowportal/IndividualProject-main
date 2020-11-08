using IndividualProject.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class CommandPromptUtilsCourse : CommandPromptUtils
    {
        public Course GetCourseDetails()
        {
            List<string> streams = new List<string>() { "C#", "Java", "Python", "JavaScript", "PHP" };
            List<string> type = new List<string>() { "Full Time", "Part Time","Hybrid" };
            Course course = new Course();
            course.Title = AskDetail("Give me the title of the course: ");
            course.Stream = AskDetail("Give me the stream of the course: ", streams);
            course.Type = AskDetail("Give me the type of the course", type);
            course.StartDate = ConvertToDateTime($"{AskDetail("Give me the start date of the course: ")}");
            course.EndDate = ConvertToDateTime($"{AskDetail("Give me the end date of the course: ")}");

            return (course);
        }
        public void PrintCoursesList(List<Course> courses)
        {
            foreach (var item in courses)
            {
                Console.WriteLine(item);
            }
        }
    }
}
