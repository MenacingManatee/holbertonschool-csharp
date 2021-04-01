using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InventoryManagement.Tests
{
    [TestClass]
    public class ClassTest
    {
        [TestMethod]
        public void TestBaseCreation()
        {
            BaseClass b = new BaseClass();

            Assert.IsNotNull(b.id);
        }
        [TestMethod]
        public void TestUserCreation()
        {
            User u = new User("Test User");

            Assert.IsNotNull(u.id);
            Assert.AreEqual(u.name, "Test User");
            Assert.IsInstanceOfType(u, typeof(BaseClass));
        }
    }
}
