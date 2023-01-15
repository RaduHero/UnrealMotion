using QuantumEngine.UnrealMotion.CoreSystem.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class Logger
    {
        public static bool IsTestMode = false;
        public static void LogInformation(string className, string methodName)
        {
            if(IsTestMode)
            {
                Console.WriteLine($"{className}.{methodName}");
            }

        }

        public static void LogStart()
        {
            Console.WriteLine("Program started.");
        }
        public static void LogFinish()
        {
            Console.WriteLine("All processes ended.");
        }

    }
}
