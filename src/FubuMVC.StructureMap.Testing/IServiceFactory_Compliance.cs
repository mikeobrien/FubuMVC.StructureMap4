using FubuMVC.Core.Runtime;
using NUnit.Framework;

namespace FubuMVC.StructureMap.Testing
{
    [TestFixture]
    public class IServiceFactory_Compliance
    {
        [Test]
        public void has_the_IServiceFactory_registered()
        {
            ContainerFacilitySource.New(x => { })
                .Get<IServiceFactory>().ShouldBeOfType<StructureMapContainerFacility>();
        }
    }
}