using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Transcation
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "The Category field is required")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public string ?Note { get; set; }
        [Required]
        [Range(1,int.MaxValue,ErrorMessage ="Amount should be grater then 0")]
        public int Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        [NotMapped]
        public  string? categorywithIcon
        {
            get
            {
                return Category == null ? "" : Category.Title;
                    //"" + Category.Title;
            }
        }
        [NotMapped]
        public string? amount_symbol
        {
            get
            {
                return ((Category == null|| Category.Type == "Expense") ? "-" : "+") + Amount.ToString("C0");
                //"" + Category.Title;
            }
        }
    }

}
