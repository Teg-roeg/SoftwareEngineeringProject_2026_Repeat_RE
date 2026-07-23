using System;
using System.Data;
using System.Diagnostics;
using Oracle.ManagedDataAccess.Client;

namespace GymSystem
{
    public class GymClass
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public string TypeCode { get; set; }
        public int InstructorID { get; set; }
        public DateTime ClassDate { get; set; }
        public string ClassTime { get; set; }
        public decimal Price { get; set; }
        public int RoomID { get; set; }
        public int Capacity { get; set; }
        public string Status { get; set; }

        public GymClass() : this(0, "", "", 0, DateTime.Today, "", 0, 0, 0, "") { }

        public GymClass(int classID, string className, string typeCode, int instructorID, DateTime classDate, string classTime, decimal price, int roomID, int capacity, string status)
        {
            ClassID = classID;
            ClassName = className;
            TypeCode = typeCode;
            InstructorID = instructorID;
            ClassDate = classDate;
            ClassTime = classTime;
            Price = price;
            RoomID = roomID;
            Capacity = capacity;
            Status = status;
        }

        public override string ToString()
        {
            return "Class ID: " + ClassID +
                   "\tClass Name: " + ClassName +
                   "\tType Code: " + TypeCode +
                   "\tInstructor ID: " + InstructorID +
                   "\tDate: " + ClassDate.ToShortDateString() +
                   "\tTime: " + ClassTime +
                   "\tPrice: " + Price +
                   "\tRoom ID: " + RoomID +
                   "\tCapacity: " + Capacity +
                   "\tStatus: " + Status;
        }

        public static DataSet GetAllClasses()
        {
            string sqlQuery = "SELECT ClassID, ClassName, TypeCode, InstructorID, ClassDate, ClassTime, Price, RoomID, Capacity, Status " +
                              "FROM Classes ORDER BY ClassID";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static DataSet GetScheduledClasses()
        {
            string sqlQuery = "SELECT ClassID, ClassName, TypeCode, InstructorID, ClassDate, ClassTime, Price, RoomID, Capacity " +
                              "FROM Classes WHERE Status = 'SCHEDULED' " +
                              "ORDER BY ClassDate, ClassTime";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static GymClass GetClass(int id)
        {
            string sqlQuery = "SELECT * FROM Classes WHERE ClassID = " + id;

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            dr.Read();

            string className = dr.GetString(1);
            string typeCode = dr.GetString(2).Trim();
            int instructorID = dr.GetInt32(3);
            DateTime classDate = dr.GetDateTime(4);
            string classTime = dr.GetString(5);
            decimal price = dr.GetDecimal(6);
            int roomID = dr.GetInt32(7);
            int capacity = dr.GetInt32(8);
            string status = dr.GetString(9);

            dr.Close();

            return new GymClass(id, className, typeCode, instructorID, classDate, classTime, price, roomID, capacity, status);
        }

        public void AddClass()
        {
            Debug.WriteLine(this);

            if (InstructorHasClass())
            {
                throw new InvalidOperationException("This instructor is already assigned to another class at this date and time.");
            }

            string sqlQuery = "INSERT INTO Classes VALUES (" +
                              ClassID + ",'" +
                              ClassName + "','" +
                              TypeCode + "'," +
                              InstructorID + "," +
                              "TO_DATE('" + ClassDate.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD'),'" +
                              ClassTime + "'," +
                              Price + "," +
                              RoomID + "," +
                              Capacity + ",'" +
                              Status + "')";

            Database.ExecuteNonQuery(sqlQuery);
        }

        public bool InstructorHasClass()
        {
            string sqlQuery = "SELECT COUNT(*) FROM Classes " +
                              "WHERE InstructorID = " + InstructorID + " " +
                              "AND ClassDate = TO_DATE('" + ClassDate.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') " +
                              "AND ClassTime = '" + ClassTime + "' " +
                              "AND Status = 'SCHEDULED' " +
                              "AND ClassID <> " + ClassID;

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            dr.Read();

            int count = Convert.ToInt32(dr.GetValue(0));

            dr.Close();

            return count > 0;
        }

        public void CancelClass()
        {
            string sqlQuery = "UPDATE Classes SET Status = 'CANCELLED' " +
                              "WHERE ClassID = " + ClassID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        public static DataSet FindClasses(string name)
        {
            string sqlQuery = "SELECT ClassID, ClassName, TypeCode, ClassDate, ClassTime, Price, Status " +
                              "FROM Classes " +
                              "WHERE Status = 'SCHEDULED' " +
                              "AND ClassName LIKE '%" + name + "%' " +
                              "ORDER BY ClassDate, ClassTime";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static int GetNextClassID()
        {
            string sqlQuery = "SELECT MAX(ClassID) FROM Classes";

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
