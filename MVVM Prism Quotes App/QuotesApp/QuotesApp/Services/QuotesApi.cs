using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using QuotesApp.Interfaces;
using QuotesApp.Model;

namespace QuotesApp.Services
{
    public class QuotesApi : IQuote
    {

        public async Task<List<Quote>> GetQuotes()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("http://www.quotes.somee.com/api/Quotes");
            return JsonConvert.DeserializeObject<List<Quote>>(response);
        }
    }
}
