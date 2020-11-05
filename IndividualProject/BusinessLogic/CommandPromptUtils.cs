using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;

namespace IndividualProject.BusinessLogic
{
    class CommandPromptUtils
    {
        public Trainer GetTrainerDetails(List<string> subjects = null)
        {
            if (subjects == null) subjects = new List<string>() { "C#", "Java", "Python", "JavaScript", "PHP" };
            Trainer trainer   = new Trainer();
            trainer.FirstName = AskDetail("Teacher, give me your first name: ");
            trainer.LastName  = AskDetail("Teacher, give me your last name: ");
            trainer.Subject   = AskDetail("Teacher, give me the subject you teach: ", subjects);
            return (trainer);
        }

        public Course GetCourseDetails(List<string> subjects = null)
        {
            Course course = new Course();

            return (course);
        }
        public Student GetStudentDetails()
        {
            Student student = new Student();
            student.FirstName = AskDetail("Student, give me your first name:");
            student.LastName = AskDetail("Student, give me your last name:");
            student.DateOfBirth = AskDetail("Student, give me your date of birth:");
            student.TuitionFee = AskDetail("Student, what is your tuition fee?");

            return (student);
        }

        public Asignment GetAsignmentDetails(List<string> subjects = null)
        {
            Asignment asignment= new Asignment();

            return (asignment);
        }

        private string AskDetail(string message, List<string> subjects = null, DateTime? dateofbirth=null, double? tuitionfee = null)//stis parametrous mporw na valw default times, edw evala null giati thelw mono gia to subject na mpei se lista kai oxi sta alla, vazw dhladh null gia na mhn mou xtuphsei se auta pou den einai subject
        {
            string result = "";
            Console.Write(message);
            if(subjects != null)
            {
                // ask for the subject the trainer teaches
                result = SelectFromListOfStrings(subjects);
            } 
            else
            {
                result = Console.ReadLine();
            }
            if(dateofbirth != null)
            {


            }




            return (result);
        }

        private string SelectFromListOfStrings(List<string> elements)
        {
            string result = "";
            int counter = 1;
            Console.WriteLine();
            foreach (var item in elements) //an grapsw foreach kai diplo tab mou kanei autoformat to foreach
            {
                Console.WriteLine($"{counter++}. {item}");
            }
            int choice = Convert.ToInt32(Console.ReadLine());
            result = elements.ElementAt(choice - 1); //elements[choice - 1];
            return (result);
        }
        public void PrintTrainersList(List<Trainer> trainers)
        {
            foreach (var item in trainers)
            {
                Console.WriteLine(item);
            }
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
//xrhsimpoihse thn AskDetail kai selectfromlistofstrings gia na kanw to course type (full time part time hybrid etc)