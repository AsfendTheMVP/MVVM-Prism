using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace QuotesApp.ViewModels
{
	public class HomePageViewModel : BindableBase,INavigatedAware
	{
        private string _message;

        public string Message
        {
            get => _message;
            set => SetProperty(ref _message , value);
        }

        public HomePageViewModel()
        {

        }

	    public void OnNavigatedFrom(NavigationParameters parameters)
	    {
	        
	    }

	    public void OnNavigatedTo(NavigationParameters parameters)
	    {
	        var message = (string)parameters["paramater"];
	        Message = message;
	    }
	}
}
