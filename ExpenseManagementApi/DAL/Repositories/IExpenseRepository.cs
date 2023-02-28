using ExpenseManagementApi.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseManagementApi.DAL.Repositories
{
    public interface IExpenseRepository
    {
        public Task<IEnumerable<Expense>> GetAllAsync();
        public Task AddExpenseAsync(Expense expense);

    }
}
