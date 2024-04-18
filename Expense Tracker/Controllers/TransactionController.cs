using Expense_Tracker.DATA;
using Expense_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime;
using System.Transactions;

namespace Expense_Tracker.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ExpenseDbContext _dbContext;

        public TransactionController(ExpenseDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var context = _dbContext.transcations.Include(T => T.Category);

            return View(await context.ToListAsync());
        }


        [HttpGet]
        public async Task<IActionResult> AddOredit(int id = 0)
        {
            CategoryIds();
            if (id == 0)
            {
                return View(new Transcation());
            }
            else
           return View( _dbContext.transcations.Find(id));
        }
        [HttpPost]
        public async Task<IActionResult> AddOredit(Transcation transaction)
        {


            if (ModelState.IsValid)
            {
                if (transaction.Id == 0)
                {
                    _dbContext.Add(transaction);
                }
                else
                _dbContext.Update(transaction);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            CategoryIds();
            return View(transaction);

        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            if (_dbContext.transcations == null)
            {
                return Problem("no transcation");
            }
            var transction = await _dbContext.transcations.FindAsync(id);
            if (transction != null)
                _dbContext.transcations.Remove(transction);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [NonAction]
        public void CategoryIds()
        {
            var category = _dbContext.categories.ToList();
            Category categorys = new Category() { CategoryId = 0, Title = "chose the category" };
            category.Insert(0, categorys);
            ViewBag.categoryforView = category;
        }

    }
}

