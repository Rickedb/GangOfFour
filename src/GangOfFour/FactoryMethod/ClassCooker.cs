using System;

namespace GangOfFour.FactoryMethod
{
    public abstract class ClassCooker<C> where C : class
    {
        public virtual C CookConcreteClass<T>()
        {
            return (C)(object)Activator.CreateInstance<T>();
        }

        public virtual C CookConcreteClass<T>(object[] parameters)
        {
            return (C)Activator.CreateInstance(typeof(T), parameters);
        }
    }
}
