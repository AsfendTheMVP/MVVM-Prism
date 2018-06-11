using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Prism.Navigation;
using QuotesApp.Model;
using QuotesApp.Interfaces;

namespace QuotesApp.ViewModels
{
	public class QuotesPageViewModel : BindableBase
	{
	    public ObservableCollection<Quote> Quotes { get; set; }
	    private IQuote _quotes;
	    public INavigationService NavigationService { get; set; }
        public QuotesPageViewModel(IQuote quotes,INavigationService navigationService)
        {
            Quotes = new ObservableCollection<Quote>();
            _quotes = quotes;
            LoadQuotes();
            NavigationService = navigationService;
        }
	    public async void LoadQuotes()
	    {
	        var quotes = await _quotes.GetQuotes();
	        foreach (var quote in quotes)
	        {
	            Quotes.Add(quote);
	        }
	    }
        private Quote _selectedQuote;

        public Quote SelectedQuote
        {
            get { return _selectedQuote; }
            set
            {
                _selectedQuote = value;
                if (_selectedQuote!=null)
                {
                    var navigationParamaters = new NavigationParameters();
                    navigationParamaters.Add("quotedetail",_selectedQuote);
                    NavigationService.NavigateAsync("QuotesDetail", navigationParamaters);
                }
            }
        }

    }
}
