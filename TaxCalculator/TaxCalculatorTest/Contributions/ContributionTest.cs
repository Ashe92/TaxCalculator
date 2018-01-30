using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxCalculator.Contributions;

namespace TaxCalculatorTest.Contributions
{
    /// <summary>
    /// Summary description for ContributionTest
    /// </summary>
    [TestClass]
    public class ContributionTest
    {
        private Contribution contr = new Contribution("EME", "Składka na ubezpieczenie emerytalne", 9.76, 3000);
        public ContributionTest()
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
        public void  ReturnValueTest()
        {
            double temp;
            temp = contr.Count();
            Assert.AreEqual(temp, 292.8);
        }

        [TestMethod]
        public void ReturnIdTest()
        {
            string temp;
            temp = contr._id;
            Assert.AreEqual(temp,"EME");
        }

        [TestMethod]
        public void ShowTextTest()
        {
            string text= "EME Składka na ubezpieczenie emerytalne 9,76: 292,8";
            string temp = contr.ShowText();
            Assert.AreEqual(temp,text);
        }
    }


}
