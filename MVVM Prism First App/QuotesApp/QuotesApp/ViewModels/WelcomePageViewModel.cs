using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace QuotesApp.ViewModels
{
	public class WelcomePageViewModel : BindableBase
	{
	    public DelegateCommand LoginCommand { get; set; }
	    public INavigationService NavigationService { get; set; }
        private string _welcomeMessage;

        public string WelcomeMessage
        {
            get { return _welcomeMessage; } 
            set { _welcomeMessage = value; }
        }

        public WelcomePageViewModel(INavigationService navigationService)
        {
            LoginCommand = new DelegateCommand(LoginMethod);
            NavigationService = navigationService;
        }

	    private void LoginMethod()
	    {
            var navigationParamaters = new NavigationParameters();
            navigationParamaters.Add("paramater",_welcomeMessage);
	        NavigationService.NavigateAsync("HomePage",navigationParamaters);
	    }
	}
}
