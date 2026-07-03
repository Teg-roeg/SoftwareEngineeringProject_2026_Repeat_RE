using System.Data;

namespace GymSystem
{
    public class Room
    {
        public int RoomID { get; set; }
        public string Description { get; set; }

        public Room(int roomID, string description)
        {
            RoomID = roomID;
            Description = description;
        }

        public static DataSet GetRooms()
        {
            string sqlQuery = "SELECT * FROM Rooms ORDER BY RoomID";
            return Database.ExecuteMultiRowQuery(sqlQuery);
        }
    }
}