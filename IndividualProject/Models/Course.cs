using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Course
    {
        private string _title;   //katw pavla sto ksekinhma gia fields (e.g _firstname)!!
        private string _stream;
        private string _type;
        private DateTime _start_date;
        private DateTime _end_date;
        public string Title
        {
            get { return (this._title); }
            set { this._title = value.ToUpper(); }
        }

        public string Stream
        {
            get { return (this._stream); }
            set { this._stream = value.ToUpper(); }
        }

        public string Type
        {
            get { return (this._type); }
            set { this._type = value.ToUpper(); }
        }
        public DateTime StartDate
        {
            get { return (this._start_date); }
            set { this._start_date = value; }
        }
        public DateTime EndDate
        {
            get { return (this._end_date); }
            set { this._end_date = value; }
        }
        public Course()
        {
            this._title = "CB XX";
            this._stream = "Some Programming Language";
            this._type = "xxFull time/xxPart time";
            this._start_date = DateTime.Parse("1/1/1901");
            this._end_date = DateTime.Parse("1/1/1901");


        }
        public override string ToString()
        {
            return ($"Course Title: {_title}\tCourse Stream: {_stream}\tCourse Type: {_type}\tCourse starts at: {_start_date}\tCourse ends at: {_end_date}");
        }
    }
}
