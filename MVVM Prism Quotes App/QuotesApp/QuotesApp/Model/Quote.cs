using System;
using System.Collections.Generic;
using System.Text;

namespace QuotesApp.Model
{
    public class Quote
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
    }
}
