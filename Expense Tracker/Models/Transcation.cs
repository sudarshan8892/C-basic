﻿namespace Expense_Tracker.Models
{
    public class Transcation
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Note { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

    }
}