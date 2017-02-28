namespace GangOfFour.UnitTest.FactoryMethod.Objects
{
    public class ConcreteProduct : AbstractProduct
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
