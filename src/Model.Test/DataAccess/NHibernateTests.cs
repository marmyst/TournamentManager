using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TournamentManager.Model.Test.DataAccess
{
    /// <summary>
    /// Summary description for NHibernateTests
    /// </summary>
    [TestClass]
    public class NHibernateTests
    {
        public NHibernateTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            //var sessionFactory = CreateSessionFactory();

            //using (var session = sessionFactory.OpenSession())
            //{
            //    using (var transaction = session.BeginTransaction())
            //    {
            //        // create a couple of Stores each with some Products and Employees
            //        var barginBasin = new Store { Name = "Bargin Basin" };
            //        var superMart = new Store { Name = "SuperMart" };

            //        var potatoes = new Product { Name = "Potatoes", Price = 3.60 };
            //        var fish = new Product { Name = "Fish", Price = 4.49 };
            //        var milk = new Product { Name = "Milk", Price = 0.79 };
            //        var bread = new Product { Name = "Bread", Price = 1.29 };
            //        var cheese = new Product { Name = "Cheese", Price = 2.10 };
            //        var waffles = new Product { Name = "Waffles", Price = 2.41 };

            //        var daisy = new Employee { FirstName = "Daisy", LastName = "Harrison" };
            //        var jack = new Employee { FirstName = "Jack", LastName = "Torrance" };
            //        var sue = new Employee { FirstName = "Sue", LastName = "Walkters" };
            //        var bill = new Employee { FirstName = "Bill", LastName = "Taft" };
            //        var joan = new Employee { FirstName = "Joan", LastName = "Pope" };

            //        // add products to the stores, there's some crossover in the products in each
            //        // store, because the store-product relationship is many-to-many
            //        AddProductsToStore(barginBasin, potatoes, fish, milk, bread, cheese);
            //        AddProductsToStore(superMart, bread, cheese, waffles);

            //        // add employees to the stores, this relationship is a one-to-many, so one
            //        // employee can only work at one store at a time
            //        AddEmployeesToStore(barginBasin, daisy, jack, sue);
            //        AddEmployeesToStore(superMart, bill, joan);

            //        // save both stores, this saves everything else via cascading
            //        session.SaveOrUpdate(barginBasin);
            //        session.SaveOrUpdate(superMart);

            //        transaction.Commit();
            //    }

            //    // retreive all stores and display them
            //    using (session.BeginTransaction())
            //    {
            //        var stores = session.CreateCriteria(typeof(Store))
            //          .List<Store>();

            //        foreach (var store in stores)
            //        {
            //            WriteStorePretty(store);
            //        }
            //    }

            //    Console.ReadKey();
            //}
        }
    }
}
