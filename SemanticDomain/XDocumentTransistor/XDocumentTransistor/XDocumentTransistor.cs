using QuantumEngine.UnrealMotion.SemanticSystem.Interfaces;
using QuantumEngine.UnrealMotion.SemanticSystem.Types;


namespace QuantumEngine.UnrealMotion.SemanticSystem.DocumentTransisitor
{
    public sealed partial class XDocumentTransistor : IXDocumentTransistor
    {
        #region Implementation Logic
        public void Run()
        {
            ITypeInterpreter interpreter = IFactory.CreateInstance<TypeInterpreter>();

        }

        #endregion
    }



}
