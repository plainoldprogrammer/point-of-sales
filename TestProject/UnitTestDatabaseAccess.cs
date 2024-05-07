using ConsoleAppDatabaseAccess.Persistence;
using ConsoleAppDatabaseAccess.Models;

namespace TestProject
{
    [TestClass]
    public class UnitTestDatabaseAccess
    {
        [TestMethod]
        public void TestMethod_001_Save_Products()
        {
            using (DbManager dbManager = new DbManager())
            {
                dbManager.ResetProductsTablePK();

                // Testing the creation and saving of the products.
                Product product1 = new Product() { Name = "Burger", Price = 75 };
                Product product2 = new Product() { Name = "Steak", Price = 75 };
                Product product3 = new Product() { Name = "Soup", Price = 75 };
                Product product4 = new Product() { Name = "Soda", Price = 25 };

                dbManager.SaveProduct(product1);
                dbManager.SaveProduct(product2);
                dbManager.SaveProduct(product3);
                dbManager.SaveProduct(product4);

                int expectedNumberOfSavedProducts = 4;
                int productsCount = dbManager.RetrieveProductsCount();
                Assert.AreEqual(expectedNumberOfSavedProducts, productsCount);


                // Testing querying and removing the products.
                product1 = dbManager.RetrieveProductById(1);
                product2 = dbManager.RetrieveProductById(2);
                product3 = dbManager.RetrieveProductById(3);
                product4 = dbManager.RetrieveProductById(4);

                dbManager.RemoveProduct(product1);
                dbManager.RemoveProduct(product2);
                dbManager.RemoveProduct(product3);
                dbManager.RemoveProduct(product4);

                int expectedNumberOfProducts = 0;
                productsCount = dbManager.RetrieveProductsCount();
                Assert.AreEqual(expectedNumberOfProducts, productsCount);
            }
        }

        [TestMethod]
        public void TestMethod_002_Save_Order()
        {
            using (DbManager dbManager = new DbManager())
            {
                dbManager.ResetProductsTablePK();
                dbManager.ResetOrdersTablePK();

                // Testing the saving of the order.
                dbManager.SaveProduct(new Product() { Name = "Steak", Price = 75 });
                dbManager.SaveProduct(new Product() { Name = "Minalese", Price = 75 });
                dbManager.SaveProduct(new Product() { Name = "Soup", Price = 75 });
                dbManager.SaveProduct(new Product() { Name = "Soda", Price = 25 });

                Product? product = new Product();
                product = dbManager.RetrieveProductByName("Minalese");

                Order order = new Order();
                order.TicketId = 1;
                order.Product = product!;

                dbManager.SaveOrder(order);

                int expectedNumberOfSavedProducts = 1;
                int ordersCount = dbManager.RetrieveOrdersCount();
                Assert.AreEqual(expectedNumberOfSavedProducts, ordersCount);


                // Testing querying and removing the products.
                dbManager.RemoveOrder(order);
                Product product1 = dbManager.RetrieveProductById(1);
                Product product2 = dbManager.RetrieveProductById(2);
                Product product3 = dbManager.RetrieveProductById(3);
                Product product4 = dbManager.RetrieveProductById(4);
                
                dbManager.RemoveProduct(product1);
                dbManager.RemoveProduct(product2);
                dbManager.RemoveProduct(product3);
                dbManager.RemoveProduct(product4);

                int expectedNumberOfOrders = 0;
                ordersCount = dbManager.RetrieveOrdersCount();
                Assert.AreEqual(expectedNumberOfOrders, ordersCount);

                int expectedNumberOfProducts = 0;
                int productsCount = dbManager.RetrieveProductsCount();
                Assert.AreEqual(expectedNumberOfProducts, productsCount);
            }    
        }

        [TestMethod]
        public void TestMethod_003_RetrieveAllOrders()
        {
            using (DbManager dbManager = new DbManager())
            {
                //Testing the orders retrieval.
                int expectedNumberOfOrders = 0;
                var ordersCount = dbManager.RetrieveAllOrders().Count();
                Assert.AreEqual(expectedNumberOfOrders, ordersCount);
            }
        }
    }
}
