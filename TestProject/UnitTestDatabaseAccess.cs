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
                Product product1 = new Product() { Name = "bistec", Price = 75 };
                Product product2 = new Product() { Name = "milanesa", Price = 75 };
                Product product3 = new Product() { Name = "caldo", Price = 75 };
                Product product4 = new Product() { Name = "refresco", Price = 25 };

                dbManager.SaveProduct(product1);
                dbManager.SaveProduct(product2);
                dbManager.SaveProduct(product3);
                dbManager.SaveProduct(product4);

                int numberOfSavedProducts = 4;
                int productsCount = dbManager.RetrieveProductsCount();

                Assert.AreEqual(numberOfSavedProducts, productsCount);



                product1 = dbManager.RetrieveProductById(1);
                product2 = dbManager.RetrieveProductById(2);
                product3 = dbManager.RetrieveProductById(3);
                product4 = dbManager.RetrieveProductById(4);

                dbManager.RemoveProduct(product1);
                dbManager.RemoveProduct(product2);
                dbManager.RemoveProduct(product3);
                dbManager.RemoveProduct(product4);

                int numberOfProductsInDb = 0;
                productsCount = dbManager.RetrieveProductsCount();

                Assert.AreEqual(numberOfProductsInDb, productsCount);
            }
        }

        [TestMethod]
        public void TestMethod_002_Save_Order()
        {
            using (DbManager dbManager = new DbManager())
            {
                dbManager.SaveProduct(new Product() { Name = "bistec", Price = 75 });
                dbManager.SaveProduct(new Product() { Name = "milanesa", Price = 75 });
                dbManager.SaveProduct(new Product() { Name = "caldo", Price = 75 });
                dbManager.SaveProduct(new Product() { Name = "refresco", Price = 25 });

                Product? product = new Product();
                product = dbManager.RetrieveProductByName("milanesa");

                Order order = new Order();
                order.TicketId = 1;
                order.Product = product!;

                dbManager.SaveOrder(order);

                int numberOfSavedProducts = 1;
                int ordersCount = dbManager.RetrieveOrdersCount();

                Assert.AreEqual(numberOfSavedProducts, ordersCount);
            }    
        }

        [TestMethod]
        public void TestMethod_003_RetrieveAllOrders()
        {
            using (DbManager dbManager = new DbManager())
            {
                var result = dbManager.RetrieveAllOrders();
            }
        }
    }
}
