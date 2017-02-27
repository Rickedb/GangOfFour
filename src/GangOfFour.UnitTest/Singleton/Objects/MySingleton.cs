using GangOfFour.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFour.UnitTest.Singleton.Objects
{
    public class MySingleton : Singularize<MySingleton>
    {
        private MySingleton()
        {

        }

        public static MySingleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new MySingleton();
                return instance;
            }
        }
    }
}
