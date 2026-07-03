using System;
using System.Data;
using System.Diagnostics;
using Oracle.ManagedDataAccess.Client;

namespace GymSystem
{
    public class Instructor
    {
        public int InstructorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Speciality { get; set; }
        public string Status { get; set; }

        public Instructor() : this(0, "", "", "", "", "", "") { }

        public Instructor(int instructorID, string firstName, string lastName,
                          string email, string phone, string speciality, string status)
        {
            InstructorID = instructorID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Speciality = speciality;
            Status = status;
        }


    }
}
