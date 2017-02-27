using GangOfFour.UnitTest.FactoryMethod.Objects.Interfaces;

namespace GangOfFour.UnitTest.FactoryMethod.Objects
{
    public class ConcreteProduct : IProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ConcreteProduct()
        {

        }

        public ConcreteProduct(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
    }
}
