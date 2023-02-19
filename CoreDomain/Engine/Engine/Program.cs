using Engine;
using QuantumEngine.UnrealMotion.CoreSystem.Interfaces;
using QuantumEngine.UnrealMotion.SemanticSystem.DocumentTransisitor;
using QuantumEngine.UnrealMotion.SemanticSystem.Interfaces;

namespace QuantumEngine.UnrealMotion.CoreSystem.Engine
{
    internal class Program
    {
        public static int Main(string[] args)
        {

            Logger.LogStart();

            IFileAssessment file = IFactory.CreateInstance<FileAssessment>();
            file.Run(ref args);

            IFilePathValidation filePathValidation = IFactory.CreateInstance<FilePath>();
            var result = filePathValidation.IsValidated(args);
            filePathValidation.ShowMessageAfterValidation(result.Message);

            if (result.ResultStatus != FilePathResultStatus.Success) return -1;

            IXDocumentTransistor xDocTransistor = IFactory.CreateInstance<XDocumentTransistor>();
            xDocTransistor.Run(args[0]);

            Logger.LogFinish();

            return 0;
        }

    }
}