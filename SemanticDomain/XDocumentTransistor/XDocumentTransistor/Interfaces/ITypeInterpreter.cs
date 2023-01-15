using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuantumEngine.UnrealMotion.SemanticSystem.Interfaces
{
    public interface ITypeInterpreter
    {
        ValueTask<XElement> InterpretDataTypes(string filePath);
    }
}
