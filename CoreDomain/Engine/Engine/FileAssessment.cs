using QuantumEngine.UnrealMotion.CoreSystem.Engine;
using QuantumEngine.UnrealMotion.CoreSystem.Interfaces;

namespace Engine
{
    internal class FileAssessment : IFileAssessment
    {
        public void Run(ref string[] args)
        {
            if(args.Length != 1)
            {
                Logger.IsTestMode = true;

                IFilePathValidation filePath = IFactory.CreateInstance<FilePath>();
                string[] arguments = new string[1] { String.Empty };
                bool isArgumentValid = false;

                do
                {
                    arguments[0] = Console.ReadLine() ?? String.Empty;
                    isArgumentValid = filePath.IsValidated(arguments).ResultStatus == FilePathResultStatus.Success;
                }
                while (!isArgumentValid);

                Logger.LogInformation(nameof(FileAssessment), nameof(FileAssessment.Run));

                args = arguments;
            }
        }
    }
}
