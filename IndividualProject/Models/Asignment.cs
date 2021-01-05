using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Assignment
    {
        private string _title;
        private string _description;
        private DateTime _deadlinedatetime;
        private float _oralmark;
        private float _totalmark;
        private string _courseChoices;
        private List<string> _coursesPerAssignment;

        public string Title
        {
            get { return (this._title); }
            set { this._title = value; }
        }

        public string Description
        {
            get { return (this._description); }
            set { this._description = value; }
        }

        public DateTime DeadlineDateTime
        {
            get { return (this._deadlinedatetime); }
            set { this._deadlinedatetime = value; }
        }

        public float OralMark
        {
            get { return (this._oralmark); }
            set { this._oralmark = value; }
        }
        public float TotalMark
        {
            get { return (this._totalmark); }
            set { this._totalmark = value; }
        }
        public string CourseChoices
        {
            get { return (this._courseChoices); }
            set { this._courseChoices = value; }
        }

        public List<string> CoursesPerAssignment
        {
            get { return (this._coursesPerAssignment); }
            set { this._coursesPerAssignment = value; }
        }
        public Assignment()
        {
            this._title = "generic title";
            this._description = "generic description";
            this._deadlinedatetime = DateTime.Parse("1/1/1901");
            this._oralmark = 00;
            this._totalmark = 00;
            List<string> courses = new List<string>();
            courses.Add("Course Title");
            this._coursesPerAssignment = courses;

        }

        public override string ToString()
        {
            return ($"Assignment Title: {_title}\tDescription of the Assignment: {_description}\tSubmission Date and Time: {_deadlinedatetime}\tOral Mark: {_oralmark}\tTotal Mark: {_totalmark}");
        }
    }
}
