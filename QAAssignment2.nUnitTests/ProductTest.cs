namespace QAAssignment2.nUnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // initialize the product object
            Product product = new Product(1, "Product1", 100, 10);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}