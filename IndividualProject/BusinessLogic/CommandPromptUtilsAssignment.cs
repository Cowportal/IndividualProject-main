using IndividualProject.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class CommandPromptUtilsAssignment:CommandPromptUtils
    {
        public Assignment GetAssignmentDetails(List<string> subjects = null)
        {
            Assignment assignment = new Assignment();
            assignment.Title = AskDetail("Give me the assignment's title: ");
            assignment.Description = AskDetail("Give me the assignment's description: ");
            assignment.DeadlineDateTime = ConvertToDateTime($"{AskDetail("Give me the assignment deadline date: ")}");
            assignment.OralMark = ConvertToFloat($"{AskDetail("Give me the oral mark of the assignment: ")}");
            assignment.TotalMark = ConvertToFloat($"{AskDetail("Give me the total mark of the assignment: ")}");
            return (assignment);
        }
        public void PrintAssignmentsList(List<Assignment> assignments)
        {
            foreach (var item in assignments)
            {
                Console.WriteLine(item);
            }
        }
    }
}
