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



        private protected List<Course> _coursesperstudent;

        public List<Course> CoursesPerStudent
        {
            get { return _coursesperstudent; }
            set { _coursesperstudent = value; }
        }


        public Student()
        {
            this._firstname = "JohnDoe";
            this._lastname = "JohnDoe";
            this._dateOfBirth = DateTime.Parse("1/1/1901");
            this._tuitionFee = 000;
            
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth,
            double tuitionFee, List<Course> coursesPerStudent)
        {

        }

        public Student (Course course1, Course course2)
        {
            course1.Title = "C";
            course2.Title = "B";
            this._coursesperstudent.Add(course1);
            this._coursesperstudent.Add(course2);
        }
        
        

        public override string ToString()
        {
            return ($"First Name: {_firstname}\tLast Name: {_lastname}\tDate of Birth: {_dateOfBirth}\tTuition Fee: {_tuitionFee}");
        }

    }
}
