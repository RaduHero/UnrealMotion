using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumEngine.UnrealMotion.CoreSystem.Interfaces
{
    internal interface IFactory
    {
        static T CreateInstance<T>() where T: class, new() => new T();
    }
}
