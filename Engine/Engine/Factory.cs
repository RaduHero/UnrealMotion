using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumEngine.AdvancedSystem.FactoryDomain.Engine
{
    public static class Factory
    {
        public static T CreateInstance<T, K>() where K : class, T, new() where T : class
        {
           T instance = new K();
           return instance;
        }


    }
}
