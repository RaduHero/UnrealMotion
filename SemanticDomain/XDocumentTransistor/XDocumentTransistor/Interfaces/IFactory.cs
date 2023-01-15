using System;


namespace QuantumEngine.UnrealMotion.SemanticSystem.Interfaces
{
    internal interface IFactory
    {
        static T CreateInstance<T>() where T : class, new() => new T();

    }
}
