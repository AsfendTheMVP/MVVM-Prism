using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using QuotesApp.Model;

namespace QuotesApp.Interfaces
{
    public interface IQuote
    {
        Task<List<Quote>> GetQuotes();
    }
}
