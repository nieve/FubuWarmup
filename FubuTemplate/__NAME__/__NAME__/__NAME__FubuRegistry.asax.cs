using __NAME__.Controllers.Home;
using FubuMVC.Core;
using FubuMVC.UI;

namespace __NAME__
{
    public class __NAME__FubuRegistry : FubuRegistry
    {
        public __NAME__FubuRegistry()
        {
            Applies.ToThisAssembly();
            
            Actions.IncludeTypesNamed(x => x.EndsWith("Controller"));
            
            Routes
                .IgnoreControllerNamespaceEntirely();

            this.UseDefaultHtmlConventions();
            HomeIs<HomeController>(c => c.Home(null));

            Views.TryToAttach(x =>
            {
                x.by_ViewModel_and_Namespace_and_MethodName();
                x.by_ViewModel_and_Namespace();
                x.by_ViewModel();
            });
        }
    }
}