using GangOfFour.FactoryMethod;

namespace GangOfFour.UnitTest.FactoryMethod.Objects
{
    public class ConcreteCreator : ClassCooker<AbstractProduct>
    {
        public override AbstractProduct CookConcreteClass<T>()
        {
            return new ConcreteProduct() { Name = "Overrided" };
        }
    }
}
