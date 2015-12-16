namespace Fillwords.WebApp.ViewModels
{
    public class ViewModelBase
    {
        public string PageTitle { get; private set; }

        public ViewModelBase()
        {
            PageTitle = "Главная";
        }

        public ViewModelBase(string pageTitle)
        {
            PageTitle = pageTitle;
        }
    }
}