using QuantumEngine.UnrealMotion.SemanticSystem.DocumentTransisitor;
using QuantumEngine.UnrealMotion.SemanticSystem.Interfaces;

namespace QuantumEngine.UnrealMotion.CoreSystem.Engine
{
    public class Program
    {
        public static int Main(string[] args)
        {
            if(args.Length > 0)
            {
                String filePath = @$"{args[0]}";
                Console.WriteLine(filePath);
            }

            IXDocumentTransistor xDocTransistor = Factory.CreateInstance<IXDocumentTransistor, XDocumentTransistor>();

             xDocTransistor.Start();

            Console.WriteLine(xDocTransistor.ToString());
            Program.StopProgram();

            return 0;
        }

        public static void StopProgram()
        {

            var x = Console.ReadLine();

            while (x != "stop")
            {
                x = Console.ReadLine();
            }
        }

    }
}