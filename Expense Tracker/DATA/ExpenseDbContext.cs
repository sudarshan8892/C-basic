using Expense_Tracker.Models;
using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.DATA
{
    public class ExpenseDbContext:DbContext

    {
        public ExpenseDbContext(DbContextOptions<ExpenseDbContext> options) :base(options)
        {
                
        }
       public  DbSet<Category> categories { get; set; }
       public  DbSet<Transcation>  transcations { get; set; }
        
    }
}
