using QuantumEngine.UnrealMotion.SemanticSystem.Interfaces;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace QuantumEngine.UnrealMotion.SemanticSystem.Types
{
    internal class TypeInterpreter : ITypeInterpreter, IFactory
    {
        #region Private Members

        private readonly string m_equalOperator = "=";

        private IList<string> m_dataTypes = new List<string>()
        {
            "i:8", "vector2d<i:8>[{0}]]",
            "i:16","vector2d<i:16>[{0}]]",
            "i:32", "vector2d<i:32>[{0}]]",
            "i:64","vector2d<i:64>[{0}]",
            "string","vector2d<string>[{0}]",
            "char", "vector2d<char>[{0}]",
            "bool", "vector2d<bool>[{0}]]",
            "dynamic", "vector2d<dynamic>[{0}]]"
        };

        #endregion

        #region Implementation Logic

        public ValueTask<XElement> InterpretDataTypes(string filePath)
        {
            string[] textData = File.ReadAllLines(filePath);

            RemoveSpacesFromStringValueData(ref textData);

            XElement xElement = new XElement("Data");

            IList<string[]> textList = new List<string[]>();
            IList<(string TypeData, string Name, string ValueData)> valueList = new List<(string TypeData, string Name, string ValueData)>();

            string[]? xValue = null;
            foreach (string data in textData)
            {
                xValue = data.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries);
                textList.Add(xValue);
            }

            try
            {
                for (int i = 0; i < textList.Count; i++)
                {
                    var ax = textList[i];
                    for (int k = 0; k < ax.Length; k++)
                    {
                        if (ax[k] == m_equalOperator)
                        {
                            valueList.Add((TypeData: ax[k - 2], Name: ax[k - 1], ValueData: ax[k + 1]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            if (valueList.Count == 0)
                return ValueTask.FromResult(new XElement("Empty"));

            foreach (var (TypeData, Name, ValueData) in valueList)
            {
                if (m_dataTypes.Contains(TypeData))
                {
                    xElement.Add(new XElement(Name, new XElement(TypeData, ValueData)));
                }
            }

            return ValueTask.FromResult(xElement);

        }

        public ValueTask RemoveSpacesFromStringValueData(ref string[] data)
        {
            StringBuilder[] stringBuilderVector = new StringBuilder[data.Length];

            int i = 0;
            while (i < data.Length)
            {
                stringBuilderVector[i] = new StringBuilder();
                stringBuilderVector[i].Append(data[i]);
                char[] charVector = data[i].ToCharArray();
                int[] indexesOfStringMark = charVector.Select((x, ix) => (x,ix)).Where((obj) => obj.x == '"').Select(obj => obj.ix).ToArray();

                if (indexesOfStringMark.Length == 0)
                    return ValueTask.CompletedTask;

                if (indexesOfStringMark.Length % 2 != 0)
                    return ValueTask.FromException(new Exception("A double quotation mark is incompleted."));

                int[] indexesOfSpace = charVector.Select((x, ix) => (x, ix)).Where((obj) => obj.x == ' ').Select(obj => obj.ix).ToArray();

                int k = 0;
                foreach(var index in indexesOfSpace)
                {
                    if (index > indexesOfStringMark[k] && index < indexesOfStringMark[k + 1])
                    {
                        if (charVector[index] == ' ')
                            stringBuilderVector[i][index] = '_';

                    }

                    if(k < indexesOfStringMark.Length - 2) k++;
                }

                stringBuilderVector[i].Remove(k + 1, 1);
                data[i] = stringBuilderVector[i].ToString();
                i++;
            }

            return ValueTask.CompletedTask;
        }

        #endregion

    }

}