using GangOfFour.CoR.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFour.CoR
{
    public class Chaining<IChain> where IChain : ICoR<object>
    {
        private List<IChain> chains;

        public Chaining()
        {
            this.chains = new List<IChain>();
        }

        public void ChainFunction(string method)
        {
            MethodInfo interfaceMethodInfo = typeof(IChain).GetMethod(method);
            interfaceMethodInfo.Invoke(chains.First(), null);
        }

        public T ChainFunction<T>(string method)
        {
            MethodInfo interfaceMethodInfo = typeof(IChain).GetMethod(method);
            return (T)interfaceMethodInfo.Invoke(chains.First(), null);
        }
    }
}
