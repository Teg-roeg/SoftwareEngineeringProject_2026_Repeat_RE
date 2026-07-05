using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
