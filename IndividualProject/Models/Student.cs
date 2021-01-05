using IndividualProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Student
    {
        private string _firstname;   //katw pavla sto ksekinhma gia fields (e.g _firstname)!!
        private string _lastname;
        private DateTime _dateOfBirth;
        private double _tuitionFee;
        private string _courseChoices;
        private List<string> _coursesPerStudent;

        public string FirstName
        {
            get { return (this._firstname); }
            set { this._firstname = value.ToUpper(); }
        }

        public string LastName
        {
            get { return (this._lastname); }
            set { this._lastname = value.ToUpper(); }
        }

        public DateTime DateOfBirth
        {
            get { return (this._dateOfBirth); }
            set { this._dateOfBirth = value; }
        }
        public double TuitionFee
        {
            get { return (this._tuitionFee); }
            set { this._tuitionFee = value; }
        }
        
        public string CourseChoices
        {
            get { return (this._courseChoices); }
            set { this._courseChoices = value; }
        }

        public List<string> CoursesPerStudent
        {
            get { return (this._coursesPerStudent); }
            set { this._coursesPerStudent = value; }
        }


        public Student()
        {
            this._firstname = "JohnDoe";
            this._lastname = "JohnDoe";
            this._dateOfBirth = DateTime.Parse("1/1/1901");
            this._tuitionFee = 000;
            List<string> courses = new List<string>();
            courses.Add("Course Title");
            this._coursesPerStudent = courses;
            
        }

        
      
        public override string ToString()
        {
            return ($"First Name: {_firstname}\tLast Name: {_lastname}\tDate of Birth: {_dateOfBirth}\tTuition Fee: {_tuitionFee}");
        }

    }
}
