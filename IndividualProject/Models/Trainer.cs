﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models//ta modela kalo einai na MHN periexoun business logic
{
    class Trainer //gia thn synexeia tou project ftiaxnw kainourgia klash "student" kai kanw ta idia
    {
        private string _firstname;   //katw pavla sto ksekinhma gia fields (e.g _firstname)!!
        private string _lastname;
        private string _subject; //must 

        public string FirstName 
        { 
            get { return (this._firstname); } 
            set { this._firstname = value.ToUpper(); } 
        }

        public string LastName
        {
            get { return (this._lastname);  }
            set { this._lastname = value.ToUpper(); }
        }

        public string Subject
        {
            get { return (this._subject); }
            set { this._subject = value.ToUpper(); }
        }

        public Trainer()
        {
            this._firstname = "JohnDoe";
            this._lastname = "JohnDoe";
            this._subject = "xSubject";
        }

        public override string ToString()
        {
            return ($"First Name: {_firstname}\tLast Name: {_lastname}\tSubject: {_subject}");
        }

       
    }
}
