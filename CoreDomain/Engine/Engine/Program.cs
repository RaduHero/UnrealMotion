using QuantumEngine.UnrealMotion.CoreSystem.Interfaces;
using QuantumEngine.UnrealMotion.SemanticSystem.DocumentTransisitor;
using QuantumEngine.UnrealMotion.SemanticSystem.Interfaces;

namespace QuantumEngine.UnrealMotion.CoreSystem.Engine
{
    public class Program
    {
        public static int Main(string[] args)
        {
            #if DEBUG

            if(args.Length != 1)
            {
                var argument = Console.ReadLine() ?? String.Empty;
                args = new string[1] { argument };
            }

            #endif

            IFilePathValidation filePathValidation = Factory.CreateInstance<IFilePathValidation, FilePath>();
            if (!filePathValidation.IsValidated(args))
                return -1;

            IXDocumentTransistor xDocTransistor = Factory.CreateInstance<IXDocumentTransistor, XDocumentTransistor>();

            xDocTransistor.Start();


            return 0;
        }

    }
}