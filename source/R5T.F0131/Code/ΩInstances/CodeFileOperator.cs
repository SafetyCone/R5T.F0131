using System;


namespace R5T.F0131
{
    public class CodeFileOperator : ICodeFileOperator
    {
        #region Infrastructure

        public static ICodeFileOperator Instance { get; } = new CodeFileOperator();


        private CodeFileOperator()
        {
        }

        #endregion
    }
}
