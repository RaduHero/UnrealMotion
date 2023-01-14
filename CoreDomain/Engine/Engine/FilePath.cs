using QuantumEngine.UnrealMotion.CoreSystem.Interfaces;


namespace QuantumEngine.UnrealMotion.CoreSystem.Engine
{
    public class FilePath : IFilePathValidation
    {
        public bool IsValidated(string[] args)
        {
            if (args.Length != 1)
                return false;

            if (!System.IO.Path.Exists(args[0]))
                return false;

            string? fileName = System.IO.Path.GetFileName(args[0]);
            if (fileName == null) 
                return false;

            var fileVector = fileName.Split('.');
            if (fileVector.Length != 2 && fileVector[1] != "motion") 
                return false;

            return true;
        }



    }
}
