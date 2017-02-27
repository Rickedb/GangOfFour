using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFour.Singleton
{
    public abstract class Singularize<T>
    {
        protected static T instance;

        public Singularize()
        {
            try
            {
                instance = Activator.CreateInstance<T>();
                throw new NotImplementedException("You class has constructors, it cannot implement Singularize");
            }
            catch (MissingMethodException) { }
        }
    }
}
