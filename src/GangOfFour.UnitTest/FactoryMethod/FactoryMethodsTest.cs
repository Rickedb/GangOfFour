using GangOfFour.FactoryMethod;
using GangOfFour.UnitTest.FactoryMethod.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GangOfFour.UnitTest.FactoryMethod
{
    [TestClass]
    public class FactoryMethodsTest
    {
        [TestMethod]
        public void TestCookingMethods()
        {
            ConcreteCreator cooker = new ConcreteCreator();

            var product1 = cooker.CookConcreteClass<ConcreteProduct>();
            var product2 = cooker.CookConcreteClass<ConcreteProduct>(new object[] { "Name", "Description" });
        }
    }
}
