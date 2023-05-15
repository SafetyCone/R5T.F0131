using System;


namespace R5T.F0131
{
    public static class Instances
    {
        public static F0124.IFileOperator FileOperator => F0124.FileOperator.Instance;
        public static Extensions.IStringOperator StringOperator_Extensions => Extensions.StringOperator.Instance;
        public static T0193.Extensions.IStringOperator StringOperator_T0193_Extensions => T0193.Extensions.StringOperator.Instance;
    }
}