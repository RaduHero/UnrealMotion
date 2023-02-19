using QuantumEngine.UnrealMotion.SemanticSystem.Interfaces;
using QuantumEngine.UnrealMotion.SemanticSystem.Types;


namespace QuantumEngine.UnrealMotion.SemanticSystem.DocumentTransisitor
{
    public sealed partial class XDocumentTransistor : IXDocumentTransistor
    {
        #region Implementation Logic
        public void Run(string filePath)
        {
            ITypeInterpreter interpreter = IFactory.CreateInstance<TypeInterpreter>();
            var response = interpreter.InterpretDataTypes(filePath);

            if(response.IsFaulted)
            {
                Console.WriteLine("Fail");
            }

            Console.WriteLine(response.Result);
        }

        #endregion
    }



}
