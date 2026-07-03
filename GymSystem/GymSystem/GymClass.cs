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

        public GymClass(int classID, string className, string typeCode, int instructorID,
                        DateTime classDate, string classTime, decimal price,
                        int roomID, int capacity, string status)
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

    }
}
