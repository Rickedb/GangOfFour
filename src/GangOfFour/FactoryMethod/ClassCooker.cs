using System;

namespace GangOfFour.FactoryMethod
{
    public class ClassCooker<I>
    {
        public ClassCooker()
        {
            if (!typeof(I).IsInterface)
                throw new NotSupportedException(typeof(I).Name + " must be an interface");
        }

        public virtual T CookConcreteClass<T>()
        {
            this.isAssignableFromClass<T>();
            return Activator.CreateInstance<T>();
        }

        public virtual T CookConcreteClass<T>(object[] parameters)
        {
            this.isAssignableFromClass<T>();
            return (T)Activator.CreateInstance(typeof(T), parameters);
        }

        private void isAssignableFromClass<T>()
        {
            if (!typeof(I).IsAssignableFrom(typeof(T)))
                throw new NotSupportedException(typeof(T).Name + " must be an implement " + typeof(I).Name);
        }
    }
}
