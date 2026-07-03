using Oracle.ManagedDataAccess.Client;
using ProductApp;
using System;
using System.Data;
using System.Diagnostics;
using System.Xml.Linq;

namespace GymSystem
{
    public class Member
    {
        // Properties
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }

        // Constructors
        public Member() : this(0, "", "", "", "", "") { }

        public Member(int memberID, string firstName, string lastName,
                      string email, string phone, string status)
        {
            MemberID = memberID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Status = status;
        }

        public override string ToString()
        {
            return "Member ID: " + MemberID + "\tName: " + FirstName + " " + LastName + "\tEmail: " + Email +
                "\tPhone: " + Phone + "\tStatus: " + Status;
        }
        public static DataSet GetAllMembers()
        {
            //Define the SQL query to be executed
            string sqlQuery = "SELECT MemberID, FirstName, LastName, Email, Phone, Status " +
                "FROM Members ORDER BY MemberID";

            //Execute the SQL query
            return Database.ExecuteMultiRowQuery(sqlQuery);
        }
    }
}
