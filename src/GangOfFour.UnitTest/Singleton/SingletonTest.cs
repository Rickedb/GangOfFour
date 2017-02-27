using GangOfFour.UnitTest.Singleton.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GangOfFour.UnitTest.Singleton
{
    [TestClass]
    public class SingletonTest
    {
        [TestMethod]
        public void SingularizeTest()
        {
            var x = MySingleton.Instance;
        }
    }
}
