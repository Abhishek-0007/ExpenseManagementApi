using ExpenseManagementApi.DAL.Entities;

namespace ExpenseManagementApi.Services
{
    public interface IExpenseService
    {
        public Task<IEnumerable<Expense>> GetAllAsync();
        public Task AddExpenseAsync(Expense expense);
    }
}
