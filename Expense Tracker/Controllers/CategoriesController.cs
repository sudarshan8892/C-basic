using Expense_Tracker.DATA;
using Expense_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Expense_Tracker.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ExpenseDbContext _context;

        public CategoriesController(ExpenseDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return _context.categories != null ? View(await _context.categories.ToListAsync()) : Problem(" some error");

        }
        [HttpGet]
        public async Task<IActionResult> AddOredit(int id = 0)
        {
            if (id == 0)
            {
                return View(new Category());
            }
            else
            {
                return View(_context.categories.Find(id));
            }


        }
        [HttpPost]
        public async Task<IActionResult> AddOredit(Category category)
        {
            if (ModelState.IsValid)
            {

                if (category.CategoryId == 0)
                {
                    _context.Add(category);
                }
                else
                    _context.Update(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(new Category());

        }
        [HttpPost]
        public async Task<IActionResult>Delete(int id)
        {
            if (_context.categories == null)
            {
                return Problem("no category");
            }
            var category = await _context.categories.FindAsync(id);
            if (category != null)
                _context.categories.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }

}
