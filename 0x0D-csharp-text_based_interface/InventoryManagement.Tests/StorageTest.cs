using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManagement.Tests
{
    [TestClass]
    public class StorageTest
    {
        [TestMethod]
        public void TestStorageCreation()
        {
            JSONStorage storage = new JSONStorage();
            User u = new User("Test User 2");

            storage.New(u);
            storage.Save();
            Assert.IsTrue(File.Exists("storage/inventory_manager.json"));
        }
        [TestMethod]
        public void TestStorageLoad()
        {
            JSONStorage storage = new JSONStorage();
            User u = new User("Test User 2");

            storage.New(u);
            storage.Save();
            storage.Load();
            Assert.IsTrue(storage.All().ContainsKey(String.Format("User.{0}", u.id)));
        }
    }
}
