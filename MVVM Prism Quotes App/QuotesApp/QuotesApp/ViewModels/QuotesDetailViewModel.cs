using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using QuotesApp.Model;

namespace QuotesApp.ViewModels
{
    public class QuotesDetailViewModel : BindableBase,INavigatedAware
    {
        private Quote quote;
        private string _quoteDescription;

        public string QuoteDescription
        {
            get { return _quoteDescription; }
            set {SetProperty(ref _quoteDescription , value); }
        }

        public QuotesDetailViewModel()
        {

        }   

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            quote = (Quote)parameters["quotedetail"];
           QuoteDescription =  quote.Description;
        }
    }
}
