using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternUnitTest.CreationalPatterns
{
    using DesignPattern.CreationalPatterns.SingletonPattern;
    [TestClass]
    public class SingletonUnitTest
    {
        //Unit Test to verify inspite of intializing 2 vairable both represent same object
        [TestMethod]
        public void VerifyOnlyOneInstance()
        {
            var obj1 = Singleton.Instance;
            var obj2 = Singleton.Instance;

            Assert.AreEqual(obj1, obj2);
        }

        //Unit Test to verify values are updated on single instance across multiple object
        [TestMethod]
        public void VerifyValueUpdates()
        {
            var obj1 = Singleton.Instance;
            obj1.IncrementCounter();
            obj1.IncrementCounter();
            Assert.AreEqual<int>(obj1.GetCounter(), 2);

            var obj2 = Singleton.Instance;
            obj2.IncrementCounter();
            obj2.IncrementCounter();
            Assert.AreEqual<int>(obj1.GetCounter(), 4);
        }
    }
}
