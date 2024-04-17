using System.Reflection.PortableExecutable;

namespace Expense_Tracker.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Title  { get; set; }
        public string Icon { get; set; } = "";
        public string Type { get; set; } = "Expense";
    }
}