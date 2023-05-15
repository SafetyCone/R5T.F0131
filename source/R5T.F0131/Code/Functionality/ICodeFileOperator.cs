using System;

using R5T.F0124;
using R5T.T0132;
using R5T.T0172;
using R5T.T0193;


namespace R5T.F0131
{
    [FunctionalityMarker]
    public partial interface ICodeFileOperator : IFunctionalityMarker
    {
        /// <returns>
        /// Returns whether or not the file was actually written.
        /// </returns>
        public bool Write_Code_Synchronous(
            ICodeFilePath codeFilePath,
            ICode code,
            FileExistsBehavior fileExistsBehavior = IFileExistsBehaviors.Default)
        {
            return Instances.FileOperator.Write_Synchronous(
                codeFilePath,
                code,
                fileExistsBehavior);
        }

        public bool Write_Code_Synchronous(
            ICodeFilePath codeFilePath,
            Func<ICode> codeGenerator,
            FileExistsBehavior fileExistsBehavior = IFileExistsBehaviors.Default)
        {
            var code = codeGenerator();

            return this.Write_Code_Synchronous(
                codeFilePath,
                code,
                fileExistsBehavior);
        }
    }
}
