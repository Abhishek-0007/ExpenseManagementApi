using ExpenseManagementApi.DAL.Entities;
using ExpenseManagementApi.DAL.Repositories;

namespace ExpenseManagementApi.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository _repository;

        public ExpenseService(IExpenseRepository expenseRepository)
        {
            _repository = expenseRepository;
        }

        public async Task AddExpenseAsync(Expense expense)
        {
            await _repository.AddExpenseAsync(expense);
        }

        public async Task<IEnumerable<Expense>> GetAllAsync()
        {
           return await _repository.GetAllAsync();
        }
    }
}
