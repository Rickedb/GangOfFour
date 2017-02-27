using GangOfFour.Prototype;

namespace GangOfFour.UnitTest.Prototype.Objects
{
    public class WithHeritagePrototype : ProtoCloner
    {
        public string Name { get; set; }

        public WithHeritagePrototype clone()
        {
            return (WithHeritagePrototype)base.clone();
        }
    }
}
