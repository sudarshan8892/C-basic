using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class DateRange
    {
        [NotMapped]
        public List<DateTime> value { get; set; }
        //{
        //    get
        //    {
        //        DateTime endDate = DateTime.Today;

        //        DateTime startDate = endDate.AddDays(-7);

        //        return new DateTime[] { startDate, endDate };
        //    }
        //    set
        //    {

        //    }
        //}
        //public DateRange(DateTime startDate, DateTime endDate)
        //{
        //    value = new DateTime[] { startDate, endDate };
        //}

    }
}
