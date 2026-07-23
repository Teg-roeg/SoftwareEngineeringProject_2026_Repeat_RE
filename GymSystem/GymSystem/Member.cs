using System;
using System.Data;
using System.Diagnostics;
using Oracle.ManagedDataAccess.Client;

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
            return "Member ID: " + MemberID + "\tName: " + FirstName + " " + LastName + "\tEmail: " + Email + "\tPhone: " + Phone + "\tStatus: " + Status;
        }
        public static DataSet GetAllMembers()
        {
            string sqlQuery = "SELECT MemberID, FirstName, LastName, Email, Phone, Status " +
                              "FROM Members ORDER BY MemberID";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static DataSet GetActiveMembers()
        {
            string sqlQuery = "SELECT MemberID, FirstName, LastName, Email, Phone " +
                              "FROM Members WHERE Status = 'ACTIVE' " +
                              "ORDER BY LastName, FirstName";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static Member GetMember(int id)
        {
            string sqlQuery = "SELECT * FROM Members WHERE MemberID = " + id;

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            dr.Read();

            string firstName = dr.GetString(1);
            string lastName = dr.GetString(2);
            string email = dr.GetString(3);
            string phone = dr.GetString(4);
            string status = dr.GetString(5);

            dr.Close();

            return new Member(id, firstName, lastName, email, phone, status);
        }

        public void AddMember()
        {
            Debug.WriteLine(this);

            string sqlQuery = "INSERT INTO Members VALUES (" + MemberID + ",'" + FirstName + "','" + LastName + "','" + Email + "','" + Phone + "','" + Status + "')";

            Database.ExecuteNonQuery(sqlQuery);
        }


        public void WithdrawMember()
        {
            string sqlQuery = "UPDATE Members SET Status = 'WITHDRAWN' " +
                              "WHERE MemberID = " + MemberID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        public static DataSet FindMembers(string name)
        {
            string sqlQuery = "SELECT MemberID, FirstName, LastName, Email, Phone, Status " +
                              "FROM Members " +
                              "WHERE Status = 'ACTIVE' " +
                              "AND (FirstName LIKE '%" + name + "%' " +
                              "OR LastName LIKE '%" + name + "%') " +
                              "ORDER BY LastName, FirstName";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static int GetNextMemberID()
        {
            string sqlQuery = "SELECT MAX(MemberID) FROM Members";

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
