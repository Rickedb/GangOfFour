using System;
using GangOfFour.Memento;
using GangOfFour.UnitTest.Memento.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GangOfFour.UnitTest.Memento
{
    [TestClass]
    public class MementoTest
    {
        [TestMethod]
        public void TestSaveStateMethod()
        {
            SnapshotMemento memento = new SnapshotMemento();
            MementoObj obj = new MementoObj();

            obj.Name = "Test";
            memento.saveState(obj);
            obj.Name = string.Empty;

            obj = memento.restoreState(obj);

            if (obj.Name != "Test")
                throw new Exception("Failed");
        }
    }
}
