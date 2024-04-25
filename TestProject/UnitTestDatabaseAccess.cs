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
                dbManager.SaveProduct(new Product() { Name = "bistec", Price = 75 });
                dbManager.SaveProduct(new Product() { Name = "milanesa", Price = 75 });
                dbManager.SaveProduct(new Product() { Name = "caldo", Price = 75 });
                dbManager.SaveProduct(new Product() { Name = "refresco", Price = 25 });

                int numberOfSavedProducts = 4;
                int productsCount = dbManager.RetrieveProductsCount();

                Assert.AreEqual(numberOfSavedProducts, productsCount);
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
