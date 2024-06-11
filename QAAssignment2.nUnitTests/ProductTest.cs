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

        // test for Product ID property
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

        // test for Price property
        // 3 Test cases for the same attribute
        // minimum value
        [TestCase(1)]
        // just above minimum value
        [TestCase(2)]
        // maximum value
        [TestCase(5000)]
        public void Price_Test(int value)
        {
            // Assign
            // the value of this test case is already assigned in the Price_Test method argument

            // Act
            _product.Price = value;

            // Assert
            Assert.That(_product.Price, Is.EqualTo(value));
        }

        // test for Stock property
        // 3 Test cases for the same attribute
        // minimum value
        [TestCase(1)]
        // just above minimum value
        [TestCase(2)]
        // maximum value
        [TestCase(100000)]
        public void Stock_Test(int value)
        {
            // Assign
            // the value of this test case is already assigned in the Stock_Test method argument

            // Act
            _product.Stock = value;

            // Assert
            Assert.That(_product.Stock, Is.EqualTo(value));
        }
    }
}