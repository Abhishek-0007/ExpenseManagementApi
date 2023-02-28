using ExpenseManagementApi.Models;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ExpenseManagementApi.DAL.Entities
{
    public class Expense
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? ExpenseID { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string ExpenseName { get; set; }
        public string ExpenseDescription { get; set; }
        public string ExpenseType { get; set;}
        public int ExpenseAmount { get; set; }
    
    }
}
