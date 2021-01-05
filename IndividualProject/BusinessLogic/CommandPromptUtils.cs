using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;

namespace IndividualProject.BusinessLogic
{
    class CommandPromptUtils //methods pou mas vohthane na sulleksoume stoixeia mesw cmd
    {
       
        private protected string AskDetail(string message, List<string> subjects = null)//stis parametrous mporw na valw default times, edw evala null giati thelw mono gia to subject na mpei se lista kai oxi sta alla, vazw dhladh null gia na mhn mou xtuphsei se auta pou den einai subject
        {
            string result ="";
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
           
            return (result);
        }

        private protected string SelectFromListOfStrings(List<string> elements)
        {
            string result = "";
            int counter = 1;
            Console.WriteLine();
            foreach (var item in elements) //an grapsw foreach kai diplo tab mou kanei autoformat to foreach
            {
                Console.WriteLine($"{counter++}. {item}");
            }
            int choice = ConvertToInt(Console.ReadLine());
            while (choice> elements.Count || choice <= 0)
            {
                Console.WriteLine("Incorrect entry, choose a valid list number ONLY: ");
                choice = ConvertToInt(Console.ReadLine());
            }
            result = elements.ElementAt(choice - 1); //elements[choice - 1];
            return (result);
        }
    
        public DateTime ConvertToDateTime(string dateValue)
        {

            bool isItDate;
            DateTime date;
            isItDate = DateTime.TryParse(dateValue, out date);


            while (dateValue == null || isItDate == false)
            {
                Console.Write("Please enter a valid date (DD/MM/YYYY): ");
                dateValue = Console.ReadLine();
                isItDate = DateTime.TryParse(dateValue, out date);
            }
            date = DateTime.Parse(dateValue);
            return (date);
        }

        public double ConvertToDouble(string dValue)
        {

            bool isItDouble;
            double d1;
            isItDouble = double.TryParse(dValue, out d1);


            while (dValue == null || isItDouble == false)
            {
                Console.Write("Please enter a valid double value: ");
                dValue = Console.ReadLine();
                isItDouble = double.TryParse(dValue, out d1);
            }
            d1 = double.Parse(dValue);
            return (d1);
        }
        public int ConvertToInt(string intValue)
        {

            bool isItInt;
            int i1;
            isItInt = int.TryParse(intValue, out i1);


            while (intValue == null || isItInt == false)
            {
                Console.Write("Please enter a valid number choice: ");
                intValue = Console.ReadLine();
                isItInt = int.TryParse(intValue, out i1);
            }
            i1 = int.Parse(intValue);
            return (i1);
        }

        public float ConvertToFloat(string fValue)
        {

            bool isItFloat;
            float f1;
            isItFloat = float.TryParse(fValue, out f1);


            while (fValue == null || isItFloat == false)
            {
                Console.Write("Please enter a valid float value: ");
                fValue = Console.ReadLine();
                isItFloat = float.TryParse(fValue, out f1);
            }
            f1 = float.Parse(fValue);
            return (f1);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        private protected Course SelectFromListOfCourses(List<Course> courses)
        {
            Course result;
            int counter = 1;
            Console.WriteLine();
            foreach (var item in courses) 
            {
                Console.WriteLine($"{counter++}. {item}");
            }
            int choice = ConvertToInt(Console.ReadLine());
            while (choice > courses.Count || choice <= 0)
            {
                Console.WriteLine("Incorrect entry, choose a valid list number ONLY: ");
                choice = ConvertToInt(Console.ReadLine());
            }
            result = courses.ElementAt(choice - 1); 
            return (result);
        }
    }
}
