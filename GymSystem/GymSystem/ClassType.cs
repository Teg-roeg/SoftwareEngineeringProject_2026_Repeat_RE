using System.Data;

namespace GymSystem
{
    public class ClassType
    {
        public string TypeCode { get; set; }
        public string Description { get; set; }

        public ClassType(string typeCode, string description)
        {
            TypeCode = typeCode;
            Description = description;
        }

        public static DataSet GetClassTypes()
        {
            string sqlQuery = "SELECT * FROM ClassTypes ORDER BY TypeCode";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }
    }
}