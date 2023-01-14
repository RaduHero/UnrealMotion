using System;


namespace QuantumEngine.UnrealEngine.SemanticSystem.PrimitiveTypes
{
    internal class PrimitivesTypesInterpreter
    {
        #region Private and protected members

        protected string m_result = String.Empty;

        #endregion

        #region
        public string Result
        {
            get
            {
                return m_result;
            }
            private set
            {
                m_result = value;
            }
        }

        #endregion

        #region Implementation Logic

        public async ValueTask<Int32> InterpretPrimitives(string filePath)
        {
            using (StreamReader reader = File.OpenText(@$"{filePath}"))
            {
                m_result = await reader.ReadLineAsync();

                Console.WriteLine(m_result);

            }

            return 0;
        }

        #endregion


    }
}