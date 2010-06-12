using FubuMVC.Core;
using FubuMVC.StructureMap.Bootstrap;
using StructureMap;

namespace _NAME_
{
    public class Global : FubuStructureMapApplication
    {
        public override FubuRegistry GetMyRegistry()
        {
            return new _NAME_FubuRegistry();
        }

        protected override void InitializeStructureMap(IInitializationExpression ex)
        {
        }
    }
}