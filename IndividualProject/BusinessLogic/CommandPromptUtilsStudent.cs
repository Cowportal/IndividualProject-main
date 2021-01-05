using IndividualProject.BusinessLogic;
using IndividualProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class CommandPromptUtilsStudent: CommandPromptUtils//kanw inherit thn CommandPromptUtils gia na exw thn ask kai ta conversions mou
    {
        public Student GetStudentDetails(List<Course> courseslist)
        {
            
            Student student = new Student();
            student.FirstName = AskDetail("Student, give me your first name:");
            student.LastName = AskDetail("Student, give me your last name:");
            student.DateOfBirth = ConvertToDateTime($"{AskDetail("Student, give me your date of birth:")}");
            student.TuitionFee = ConvertToDouble($"{AskDetail("Student, give me your tuition fee: ")}");

            List<string> titlechoicesofcourses = new List<string>();
            

            foreach (Course any_onecourseinlist in courseslist)
            {
                titlechoicesofcourses.Add(any_onecourseinlist.Title);
            }
            
            titlechoicesofcourses.Add("exit");
            
            for (int i = 1; i <= courseslist.Count; i++)
            {
                string courseorexit = AskDetail("Student, please choose your course: ", titlechoicesofcourses);
                
                
                if (courseorexit == "exit")
                {
                    break;
                }
                student.CoursesPerStudent.Add(courseorexit);

                


            }
            

            return (student);
        }
        public void PrintStudentsList(List<Student> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
                foreach (string course in item.CoursesPerStudent)
                { Console.WriteLine(course); }
            }
        }
    }
}
