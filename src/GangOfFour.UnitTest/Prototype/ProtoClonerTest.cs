using GangOfFour.Prototype;
using GangOfFour.UnitTest.Prototype.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFour.UnitTest.Prototype
{
    [TestClass]
    public class ProtoClonerTest
    {
        [TestMethod]
        public void TestCloneMethods()
        {
            ProtoCloner cloner = new ProtoCloner();
            OnlyPrototype onlyPrototype = new OnlyPrototype();
            onlyPrototype.Name = "Prototype";
            onlyPrototype.RandomClass = new RandomClass();
            onlyPrototype.RandomClass.myInt = 5;
            onlyPrototype.RandomClass.myString = "RandomClass";

            var onlyPrototypeClone = cloner.clone(onlyPrototype);

            if (onlyPrototype.Name != onlyPrototypeClone.Name ||
                onlyPrototype.RandomClass.myInt != onlyPrototypeClone.RandomClass.myInt ||
                onlyPrototype.RandomClass.myString != onlyPrototypeClone.RandomClass.myString)
                throw new Exception("Cloning an object not working, names aren't equal");

            WithHeritagePrototype heritagePrototype = new WithHeritagePrototype();
            var heritagePrototypeClone = heritagePrototype.clone();

            if(heritagePrototype.Name != heritagePrototypeClone.Name)
                throw new Exception("Cloning with heritage not working, names aren't equal");
        }
    }
}
