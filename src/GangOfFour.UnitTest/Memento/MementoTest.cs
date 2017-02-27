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

        [TestMethod]
        public void TestPushStateMethod()
        {
            SnapshotMemento memento = new SnapshotMemento();
            MementoObj obj = new MementoObj();

            obj.Name = "Object 1";
            memento.pushState(obj);

            //Pulled back obj
            obj.Name = "New Object 1";
            memento.pushState(obj);

            obj.Name = "New Object 2";
            memento.pushState(obj);

            obj.Name = "New Object 3";
            memento.pushState(obj);

            obj = memento.restoreState(obj, -1);

            //Return same object, because we cant return 0 objects ou lesser
            if (obj.Name != "New Object 3")
                throw new Exception("Failed on 0 or less");

            //Return previous 2 from pushed list
            obj = memento.restoreState(obj, 2);
            if (obj.Name != "New Object 2")
                throw new Exception("Failed when getting Previous state");

            //Returns first pushed object
            obj = memento.restoreState(obj, 20);
            if (obj.Name != "Object 1")
                throw new Exception("Failed when getting state index higher than count");
        }
    }
}
