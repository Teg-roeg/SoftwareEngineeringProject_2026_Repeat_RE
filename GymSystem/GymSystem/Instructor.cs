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

        public void AddInstructor()
        {
            Debug.WriteLine(this);

            string sqlQuery = "INSERT INTO Instructors VALUES (" + InstructorID + ",'" + FirstName + "','" + LastName + "','" + Email + "','" + Phone + "','" + Speciality + "','" + Status + "')";

            Database.ExecuteNonQuery(sqlQuery);
        }

        public void UpdateInstructor()
        {
            string sqlQuery = "UPDATE Instructors SET " +
                              "InstructorID = " + InstructorID + "," +
                              "FirstName = '" + FirstName + "'," +
                              "LastName = '" + LastName + "'," +
                              "Email = '" + Email + "'," +
                              "Phone = '" + Phone + "'," +
                              "Speciality = '" + Speciality + "'," +
                              "Status = '" + Status + "' " +
                              "WHERE InstructorID = " + InstructorID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        public void DeRegisterInstructor()
        {
            string sqlQuery = "UPDATE Instructors SET Status = 'DEREGISTERED' " +
                              "WHERE InstructorID = " + InstructorID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        public static DataSet FindInstructors(string name)
        {
            string sqlQuery = "SELECT InstructorID, FirstName, LastName, Email, Phone, Speciality, Status " +
                              "FROM Instructors " +
                              "WHERE FirstName LIKE '%" + name + "%' " +
                              "OR LastName LIKE '%" + name + "%' " +
                              "ORDER BY LastName, FirstName";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static int GetNextInstructorID()
        {
            string sqlQuery = "SELECT MAX(InstructorID) FROM Instructors";

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            int nextId;

            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
                nextId = dr.GetInt32(0) + 1;

            dr.Close();

            return nextId;
        }
    }
}
