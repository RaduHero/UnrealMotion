using QuantumEngine.AdvancedSystem.Transistor.Interfaces;


namespace QuantumEngine.AdvancedSystem.SemanticDomain.Transistor
{
    public sealed partial class XDocumentTransistor
    {
        public string? Document = "D";

    }
    public sealed partial class XDocumentTransistor : IXDocumentTransistor
    {
        public XDocumentTransistor() 
        {
            
        }
        public void Start()
        {

        }
    }

    public sealed partial class XDocumentTransistor : SystemExceptionDocument
    {
        public void End()
        {

        }
    }

}
