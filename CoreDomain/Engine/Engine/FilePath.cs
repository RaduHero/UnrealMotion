using Engine;
using QuantumEngine.UnrealMotion.CoreSystem.Interfaces;


namespace QuantumEngine.UnrealMotion.CoreSystem.Engine
{
    internal class FilePath : IFilePathValidation
    {
        public (FilePathResultStatus ResultStatus, string Message) IsValidated(string[] args)
        {
            if(args == null)
                return (FilePathResultStatus.Error, $"Data parameter \"args\" is null. Result status: {nameof(FilePathResultStatus.Error)}");

            if (args.Length != 1)
                return (FilePathResultStatus.Error, $"Data parameter \"args\" can't take more than 1 path. Result status: {nameof(FilePathResultStatus.Error)}");

            if (args[0] == null) 
                return (FilePathResultStatus.Error, $"Index 0 of data parameter \"args\" is null. Result status: {nameof(FilePathResultStatus.Error)}");

            if (!System.IO.Path.Exists(args[0]))
                return (FilePathResultStatus.Error, $"Path does not exist. Result status: {nameof(FilePathResultStatus.Error)}");

            string? fileName = System.IO.Path.GetFileName(args[0]);
            if (fileName == null) 
                return (FilePathResultStatus.Error, $"File name cannot be found. Result status: {nameof(FilePathResultStatus.Error)}");

            var fileVector = fileName.Split('.');
            if (fileVector.Length != 2 && fileVector[1] != "txt") 
                return (FilePathResultStatus.Error, $"File name has a wrong type of extension. Result status: {nameof(FilePathResultStatus.Error)}");

            Logger.LogInformation(nameof(FilePath), nameof(FilePath.IsValidated));

            return (FilePathResultStatus.Success, $"Validation was successfully made.");
        }

        public void ShowMessageAfterValidation(string message)
        {
            Console.WriteLine(message);
        }
    }
}
