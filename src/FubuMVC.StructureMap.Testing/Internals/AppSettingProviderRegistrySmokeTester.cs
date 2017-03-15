using FubuCore.Configuration;
using FubuCore.Conversion;
using NUnit.Framework;
using Should;
using StructureMap;

namespace FubuMVC.StructureMap.Testing.Internals
{
    [TestFixture]
    public class AppSettingProviderRegistrySmokeTester
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void can_build_an_app_settings_provider_object()
        {
            var container = new Container(new AppSettingProviderRegistry());
            container.GetInstance<AppSettingsProvider>().ShouldNotBeNull();
        }

        [Test]
        public void can_build_the_object_converter()
        {
            var container = new Container(new AppSettingProviderRegistry());
            container.GetInstance<IObjectConverter>().ShouldNotBeNull();
        }
    }
}