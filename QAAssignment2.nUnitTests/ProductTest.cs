namespace QAAssignment2.nUnitTests
{
    public class Tests
    {
        // declare a private Product object
        private Product _product;

        [SetUp]
        public void Setup()
        {
            // initialize the product object
            _product = new Product(1, "Product1", 100, 10);
        }

        // test for Product ID
        // 3 Test cases for the same attribute
        // minimum value
        [TestCase(1)]
        // just above minimum value
        [TestCase(2)]
        // maximum value
        [TestCase(10000)]
        public void ProductID_Test(int value)
        {
            // Assign
            // the value of this test case is already assigned in the ProductID_Test method argument

            // Act
            _product.ProductID = value;

            // Assert
            Assert.That(_product.ProductID, Is.EqualTo(value));
        }
    }
}