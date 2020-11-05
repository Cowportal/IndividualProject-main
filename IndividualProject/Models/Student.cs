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
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return ($"First Name: {_firstname}\tLast Name: {_lastname}\tDate of Birth: {_dateOfBirth}\tTuition Fee: {_tuitionFee}");
        }

    }
}
