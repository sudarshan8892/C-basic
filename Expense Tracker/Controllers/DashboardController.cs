using Expense_Tracker.DATA;
using Expense_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Transactions;

namespace Expense_Tracker.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ExpenseDbContext _dbcontext;

        public DashboardController(ExpenseDbContext expenseDb)
        {
            _dbcontext = expenseDb;
        }
        public async Task<IActionResult> Index()
        {
            DateTime startDate = DateTime.Today.AddDays(-6);
           
            DateTime endDate = DateTime.Today;
            List<Transcation> transactions = await _dbcontext.transcations.Include(a => a.Category).Where(t => t.Date >= startDate && t.Date <= endDate).ToListAsync();
            //Income
            int totalIncome = transactions.Where(C => C.Category.Type == "Income").Sum(a => a.Amount);
            ViewBag.totalIncome = totalIncome.ToString("C0");

            //expense
            int totalexpensive = transactions.Where(C => C.Category.Type == "Expense").Sum(a => a.Amount);
            ViewBag.totalexpensive = totalexpensive.ToString("C0");
            //Balance
            int balance = totalIncome - totalexpensive;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-Us");
            culture.NumberFormat.CurrencyNegativePattern = 1;
            ViewBag.Balance = string.Format(culture, "{0:C0}", balance);


            #region Donut chart
            ////Donut chart
            ViewBag.donutchart = transactions.Where(i => i.Category.Type == "Expense")
                                  .GroupBy(a => a.Category.CategoryId)
                                  .Select(k => new
                                  {
                                      categorywithicon = k.First().Category.Icon + " " + k.First().Category.Title,
                                      amount = k.Sum(j => j.Amount),//.ToString("C0"),
                                      formateamount = k.Sum(j => j.Amount).ToString("C0"),
                                  }).OrderByDescending(l => l.amount)
                                  .ToList();


            #endregion End Donut chart

            #region Spline chart start
            //Income
            List<splineChartData> summaryincome = transactions.Where(
            i => i.Category.Type == "Income").GroupBy(j => j.Date).
            Select(k => new splineChartData()
            {
                day = k.First().Date.ToString("dd-MMM"),
                Income = k.Sum(w => w.Amount)
            }).ToList();
            //Expense
            List<splineChartData> summaryexpense = transactions.Where(
              i => i.Category.Type == "Expense").GroupBy(j => j.Date).
            Select(k => new splineChartData()
             {
             day = k.First().Date.ToString("dd-MMM"),
             Expense = k.Sum(w => w.Amount)
            }).ToList();


            string[] Last7Days = Enumerable.Range(0, 7)
           .Select(i => startDate.AddDays(i).ToString("dd-MMM"))
           .ToArray();

            ViewBag.SplineChartData = from day in Last7Days
                                      join Income in summaryincome on day equals Income.day into dayIncomeJoined
                                      from Income in dayIncomeJoined.DefaultIfEmpty()
                                      join Expense in summaryexpense on day equals Expense.day into expenseJoined
                                      from Expense in expenseJoined.DefaultIfEmpty()
                                      select new
                                      {
                                          day = day,
                                           Income = Income == null ? 0 : Income.Income,
                                          Expense = Expense == null ? 0 : Expense.Expense,
                                      };
            #endregion Spline chart End

            return View();

        }
        public class splineChartData
        {
            public string day;
            public int? Income;
            public int? Expense;

        }
    }
}
