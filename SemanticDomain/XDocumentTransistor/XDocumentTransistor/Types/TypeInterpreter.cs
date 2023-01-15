using QuantumEngine.UnrealMotion.SemanticSystem.Interfaces;
using System;
using System.Xml.Linq;

namespace QuantumEngine.UnrealMotion.SemanticSystem.Types
{
    internal class TypeInterpreter : ITypeInterpreter, IFactory
    {

        #region Implementation Logic

        public async ValueTask<XElement> InterpretDataTypes(string filePath)
        {
            using (StreamReader reader = File.OpenText(filePath))
            {
                await Task.Delay(0);



                return new XElement(String.Empty);
            }
        }

        #endregion

    }

}