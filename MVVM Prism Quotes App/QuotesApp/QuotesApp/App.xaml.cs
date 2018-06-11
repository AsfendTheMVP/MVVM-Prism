using Prism;
using Prism.Ioc;
using QuotesApp.ViewModels;
using QuotesApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;
using QuotesApp.Interfaces;
using QuotesApp.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace QuotesApp
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            //await NavigationService.NavigateAsync("NavigationPage/WelcomePage");
            await NavigationService.NavigateAsync("NavigationPage/QuotesPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<QuotesPage>();
            containerRegistry.RegisterSingleton<IQuote,QuotesApi>();
            containerRegistry.RegisterForNavigation<QuotesDetail>();
        }
    }
}
