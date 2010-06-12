using FubuMVC.Core;
using FubuMVC.StructureMap.Bootstrap;
using StructureMap;

namespace __NAME__
{
    public class Global : FubuStructureMapApplication
    {
        public override FubuRegistry GetMyRegistry()
        {
            return new __NAME__FubuRegistry();
        }

        protected override void InitializeStructureMap(IInitializationExpression ex)
        {
        }
    }
}