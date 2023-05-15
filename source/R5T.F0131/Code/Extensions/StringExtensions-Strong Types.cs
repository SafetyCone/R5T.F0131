using System;

using R5T.T0193;


namespace R5T.F0131.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToCode(string)"/>
        public static ICode ToCode(this string value)
        {
            return Instances.StringOperator_Extensions.ToCode(value);
        }

        /// <inheritdoc cref="IStringOperator.ToCode_WithoutTrim(string)"/>
        public static ICode ToCode_WithoutTrim(this string value)
        {
            return Instances.StringOperator_Extensions.ToCode_WithoutTrim(value);
        }

        /// <inheritdoc cref="IStringOperator.ToCodeFileContent(string)"/>
        public static ICodeFileContent ToCodeFileContent(this string value)
        {
            return Instances.StringOperator_Extensions.ToCodeFileContent(value);
        }

        /// <inheritdoc cref="IStringOperator.ToCodeFileContent_WithoutTrim(string)"/>
        public static ICodeFileContent ToCodeFileContent_WithoutTrim(this string value)
        {
            return Instances.StringOperator_Extensions.ToCodeFileContent_WithoutTrim(value);
        }
    }
}
