using System;

namespace QuantumEngine.UnrealMotion.CoreSystem.Interfaces
{
    internal interface IFactory
    {
        static T CreateInstance<T>() where T: class, new() => new T();
    }
}
