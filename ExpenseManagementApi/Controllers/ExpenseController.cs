using ExpenseManagementApi.DAL.Entities;
using ExpenseManagementApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseManagementApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpenseController : ControllerBase
    {
        private readonly IExpenseService _service;
        public ExpenseController(IExpenseService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Expense>> GetAll()
        {
            return await _service.GetAllAsync();
        }

        [HttpPost]
        public async Task Post(Expense expense)
        {
            await _service.AddExpenseAsync(expense);

            //return CreatedAtAction("Created Successfully", expense);
         }
    }
}
