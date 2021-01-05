using IndividualProject.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class CommandPromptUtilsTrainer: CommandPromptUtils //kanw inherit thn CommandPromptUtils gia na exw tis ask kai ta conversions mou
    {
        public Trainer GetTrainerDetails(List<Course> courseslist)
        {
            List<string> subjects = new List<string>() { "C#", "Java", "Python", "JavaScript", "PHP" };
            Trainer trainer = new Trainer();
            trainer.FirstName = AskDetail("Teacher, give me your first name: ");
            trainer.LastName = AskDetail("Teacher, give me your last name: ");
            trainer.Subject = AskDetail("Teacher, give me the subject you teach: ", subjects);
            List<string> titlechoicesofcourses = new List<string>();


            foreach (Course any_onecourseinlist in courseslist)
            {
                titlechoicesofcourses.Add(any_onecourseinlist.Title);
            }

            titlechoicesofcourses.Add("exit");

            for (int i = 1; i <= courseslist.Count; i++)
            {
                string courseorexit = AskDetail("trainer, please choose your course: ", titlechoicesofcourses);


                if (courseorexit == "exit")
                {
                    break;
                }
                trainer.CoursesPerTrainer.Add(courseorexit);




            }
            return (trainer);
        }
        public void PrintTrainersList(List<Trainer> trainers)
        {
            foreach (var item in trainers)
            {
                Console.WriteLine(item);
                foreach (string course in item.CoursesPerTrainer)
                { Console.WriteLine(course); }
            }
        }
    }
}
