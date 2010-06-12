using _NAME_.Controllers.Home;
using FubuMVC.Core;
using FubuMVC.UI;

namespace _NAME_
{
    public class _NAME_FubuRegistry : FubuRegistry
    {
        public _NAME_FubuRegistry()
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