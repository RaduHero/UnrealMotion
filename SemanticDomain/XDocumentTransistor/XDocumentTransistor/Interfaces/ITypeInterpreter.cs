using System.Xml.Linq;

namespace QuantumEngine.UnrealMotion.SemanticSystem.Interfaces
{
    public interface ITypeInterpreter
    {
        ValueTask<XElement> InterpretDataTypes(string filePath);
    }
}
