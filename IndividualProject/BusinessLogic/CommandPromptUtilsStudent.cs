using IndividualProject.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class CommandPromptUtilsStudent:CommandPromptUtils
    {
        public Student GetStudentDetails()
        {
            Student student = new Student();
            student.FirstName = AskDetail("Student, give me your first name:");
            student.LastName = AskDetail("Student, give me your last name:");
            student.DateOfBirth = ConvertToDateTime($"{AskDetail("Student, give me your date of birth:")}");
            student.TuitionFee = ConvertToDouble($"{AskDetail("Student, give me your tuition fee: ")}");

            return (student);
        }
        public void PrintStudentsList(List<Student> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }
    }
}
