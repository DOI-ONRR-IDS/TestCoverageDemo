using TestCoverageDemo;

namespace TestCoverageDemoTests
{
    [TestClass]
    public class DogTests
    {
        [TestMethod]
        [DataRow("Balto")]
        public void Bark_WhenValid_ReturnsName(string name)
        {
            var dog = new Dog(name);

            var output = dog.Bark();

            Assert.AreEqual(name, output);
        }
    }
}