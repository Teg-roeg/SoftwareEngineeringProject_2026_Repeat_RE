using System;
using System.Data;
using System.Diagnostics;
using Oracle.ManagedDataAccess.Client;

namespace GymSystem
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int MemberID { get; set; }
        public int ClassID { get; set; }
        public DateTime BookingDate { get; set; }
        public string Status { get; set; }

        public Booking() : this(0, 0, 0, DateTime.Today, "") { }

        public Booking(int bookingID, int memberID, int classID, DateTime bookingDate, string status)
        {
            BookingID = bookingID;
            MemberID = memberID;
            ClassID = classID;
            BookingDate = bookingDate;
            Status = status;
        }

        public override string ToString()
        {
            return "Booking ID: " + BookingID + "\tMember ID: " + MemberID + "\tClass ID: " + ClassID + "\tBooking Date: " + BookingDate.ToShortDateString() + "\tStatus: " + Status;
        }

        public static DataSet GetAllBookings()
        {
            string sqlQuery = "SELECT BookingID, MemberID, ClassID, BookingDate, Status " +
                              "FROM Bookings ORDER BY BookingID";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static DataSet GetBooking(int memberID)
        {
            string sqlQuery = "SELECT BookingID, MemberID, ClassID, BookingDate, Status " +
                              "FROM Bookings WHERE MemberID = " + memberID + " ORDER BY BookingDate";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public void AddBooking()
        {
            Debug.WriteLine(this);

            if (MemberHasTimeClass())
            {
                throw new InvalidOperationException("This member already has a booking for another class at the same date and time.");
            }

            if (ClassIsFull())
            {
                throw new InvalidOperationException("This class is already full.");
            }

            string sqlQuery = "INSERT INTO Bookings VALUES (" + BookingID + "," + MemberID + "," + ClassID + "," + "TO_DATE('" + BookingDate.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD'),'" + Status + "')";

            Database.ExecuteNonQuery(sqlQuery);
        }

        public bool MemberHasTimeClass()
        {
            string sqlQuery = "SELECT COUNT(*) " +
                              "FROM Bookings b " +
                              "JOIN Classes c ON b.ClassID = c.ClassID " +
                              "WHERE b.MemberID = " + MemberID + " " +
                              "AND b.Status = 'BOOKED' " +
                              "AND c.ClassDate = (SELECT ClassDate FROM Classes WHERE ClassID = " + ClassID + ") " +
                              "AND c.ClassTime = (SELECT ClassTime FROM Classes WHERE ClassID = " + ClassID + ") " +
                              "AND b.BookingID <> " + BookingID;

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            dr.Read();

            int count = Convert.ToInt32(dr.GetValue(0));

            dr.Close();

            return count > 0;
        }

        public bool ClassIsFull()
        {
            string capacitySql = "SELECT Capacity FROM Classes WHERE ClassID = " + ClassID;

            OracleDataReader drCapacity = Database.ExecuteSingleRowQuery(capacitySql);

            drCapacity.Read();

            int capacity = drCapacity.GetInt32(0);

            drCapacity.Close();


            string bookingCountSql = "SELECT COUNT(*) " + 
                                     "FROM Bookings " +
                                     "WHERE ClassID = " + ClassID + " " +
                                     "AND Status = 'BOOKED'";

            OracleDataReader drCount = Database.ExecuteSingleRowQuery(bookingCountSql);

            drCount.Read();

            int bookingCount = Convert.ToInt32(drCount.GetValue(0));

            drCount.Close();

            return bookingCount >= capacity;
        }

        public void CancelBooking()
        {
            string sqlQuery = "UPDATE Bookings SET Status = 'CANCELLED' " +
                              "WHERE BookingID = " + BookingID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        public static DataSet FindBookings(string name)
        {
            string sqlQuery = "SELECT b.BookingID, b.MemberID, b.ClassID, b.BookingDate, b.Status " +
                              "FROM Bookings b " +
                              "JOIN Members m ON b.MemberID = m.MemberID " +
                              "WHERE m.FirstName LIKE '%" + name + "%' " +
                              "OR m.LastName LIKE '%" + name + "%' " +
                              "ORDER BY b.BookingDate";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static int GetNextBookingID()
        {
            string sqlQuery = "SELECT MAX(BookingID) FROM Bookings";

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
