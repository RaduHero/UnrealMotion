using System;


namespace QuantumEngine.UnrealMotion.CoreSystem.Interfaces
{
    internal interface IFilePathValidation
    {
        (FilePathResultStatus ResultStatus, string Message) IsValidated(string[] args);
        void ShowMessageAfterValidation(string message);
    }
}
