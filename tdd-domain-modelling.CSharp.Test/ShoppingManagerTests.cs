using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class ShoppingManagerTest
    {
        //As a supermarket shopper, So that I can restock my cupboard, I want to add products into my basket.
        [Test]
        public void AddProductsTest()
        {
            string product = "Apple";
            int price = 5;
            bool expected = true;
            ShoppingManager shoppingManager = new ShoppingManager();

            bool result = shoppingManager.Add(product, price);

            Assert.AreEqual(expected, result);

        }

        [Test]
        public void ProductAlreadyInBasketTest()
        {
            string product = "Banana";
            int price = 4;
            bool expected = false;
            ShoppingManager shoppingManager = new ShoppingManager();

            bool result = shoppingManager.Add(product, price);

            Assert.AreEqual(expected, result);

        }

        //As a supermarket shopper, So that I can Pay for products at checkout, I'd like to be able to know the total cost of items in my basket,
        [Test]
        public void TotalCostOfBasketTest()
        {

            string product = "Apple";
            int price = 5;
            int expected = 9;
            ShoppingManager shoppingManager = new ShoppingManager();

            bool addproduct = shoppingManager.Add(product, price);
            int result = shoppingManager.Total();

            Assert.AreEqual(expected, result);

        }
    }
}