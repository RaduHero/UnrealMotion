using System;


namespace QuantumEngine.UnrealMotion.CoreSystem.Engine
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
