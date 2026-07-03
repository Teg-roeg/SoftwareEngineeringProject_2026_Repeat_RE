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
        public override string ToString()
        {
            return "Instructor ID: " + InstructorID + "\tName: " + FirstName + " " + LastName + "\tEmail: " + Email + "\tPhone: " + Phone + "\tSpeciality: " + Speciality + "\tStatus: " + Status;
        }

        public static DataSet GetAllInstructors()
        {
            string sqlQuery = "SELECT InstructorID, FirstName, LastName, Email, Phone, Speciality, Status " +
                              "FROM Instructors ORDER BY InstructorID";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static DataSet GetActiveInstructors()
        {
            string sqlQuery = "SELECT InstructorID, FirstName, LastName, Speciality " +
                              "FROM Instructors WHERE Status = 'ACTIVE' " +
                              "ORDER BY LastName, FirstName";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static Instructor GetInstructor(int id)
        {
            string sqlQuery = "SELECT * FROM Instructors WHERE InstructorID = " + id;

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            dr.Read();

            string firstName = dr.GetString(1);
            string lastName = dr.GetString(2);
            string email = dr.GetString(3);
            string phone = dr.GetString(4);
            string speciality = dr.GetString(5);
            string status = dr.GetString(6);

            dr.Close();

            return new Instructor(id, firstName, lastName, email, phone, speciality, status);
        }


    }
}
