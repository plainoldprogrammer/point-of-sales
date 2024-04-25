using ConsoleAppDatabaseAccess.Persistence;
using ConsoleAppDatabaseAccess.Models;

namespace TestProject
{
    [TestClass]
    public class UnitTestDatabaseAccess
    {
        [TestMethod]
        public void Test_Method_001_Save_Products()
        {
            using (DbManager dbManager = new DbManager())
            {
                dbManager.SaveProduct(new Product() { Name = "bistec", Price = 75 });
                dbManager.SaveProduct(new Product() { Name = "milanesa", Price = 75 });
                dbManager.SaveProduct(new Product() { Name = "caldo", Price = 75 });
                dbManager.SaveProduct(new Product() { Name = "refresco", Price = 25 });
            }
        }

        [TestMethod]
        public void Test_Method_002_Save_Order()
        {
            using (DbManager dbManager = new DbManager())
            {
                Product? product = new Product();
                product = dbManager.RetrieveProductByName("milanesa");

                Order order = new Order();
                order.TicketId = 2;
                order.Product = product!;

                dbManager.SaveOrder(order);
            }    
        }

        [TestMethod]
        public void Test_Method_003_RetrieveAllOrders()
        {
            using (DbManager dbManager = new DbManager())
            {
                var result = dbManager.RetrieveAllOrders();
            }
        }
    }
}
