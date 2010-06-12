using FubuMVC.Core.View;

namespace __NAME__.Controllers.Home
{
    public class HomeController
    {
        public HomeViewModel Home(HomeInputViewModel model)
        {
            return new HomeViewModel();
        }
    }

    public class HomeInputViewModel
    {
    }

    public class HomeViewModel
    {

    }

    public class HomeView : FubuPage<HomeViewModel>
    {
    }
}