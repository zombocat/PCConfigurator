using NUnit.Framework;
using PCConfigurator.Components;

namespace PCConfigurator.Test
{
    public class ConfigurationBuilderTests
    {
        [Test]
        public void AddToEmptyConfiguration()
        {
            var emptyConfiguration = new Configuration();
            var monitor = new Component(1, "Asus VA24EHE");

            var configurationBuilder = new ConfigurationBuilder();
            var modifiedConfiguration = configurationBuilder.AddComponent(emptyConfiguration, monitor);

            Assert.AreEqual(1, modifiedConfiguration.Monitors.Count);
        }
    }
}
