using ExpenseManagementApi.DAL.Entities;
using ExpenseManagementApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ExpenseManagementApi.DAL.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly IMongoCollection<Expense> _mongoCollection;

        public ExpenseRepository(IOptions<DatabaseSettings> databaseSettings)
        {
            var mongoClient = new MongoClient(
            databaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                databaseSettings.Value.DatabaseName);

            _mongoCollection = mongoDatabase.GetCollection<Expense>(
                databaseSettings.Value.ExpenseManagementName);
        }

        public async Task AddExpenseAsync(Expense expense)
        {
            await _mongoCollection.InsertOneAsync(expense);
        }

        public async Task<IEnumerable<Expense>> GetAllAsync()
        {
            return await _mongoCollection.Find(_ => true).ToListAsync();
        }
    }
}
