using IndividualProject.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class CommandPromptUtilsTrainer:CommandPromptUtils
    {
        public Trainer GetTrainerDetails()
        {
            List<string> subjects = new List<string>() { "C#", "Java", "Python", "JavaScript", "PHP" };
            Trainer trainer = new Trainer();
            trainer.FirstName = AskDetail("Teacher, give me your first name: ");
            trainer.LastName = AskDetail("Teacher, give me your last name: ");
            trainer.Subject = AskDetail("Teacher, give me the subject you teach: ", subjects);
            return (trainer);
        }
        public void PrintTrainersList(List<Trainer> trainers)
        {
            foreach (var item in trainers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
