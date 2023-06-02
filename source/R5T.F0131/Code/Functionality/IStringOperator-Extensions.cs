using System;

using R5T.T0132;
using R5T.T0193;


namespace R5T.F0131.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <summary>
        /// Trims the input. If you do not want your input trimmed, see <see cref="ToCode_WithoutTrim(string)"/>.
        /// </summary>
        public ICode ToCode(string value)
        {
            var trimmedValue = value.Trim();

            var output = this.ToCode_WithoutTrim(trimmedValue);
            return output;
        }

        /// <summary>
        /// Does not trim the input. If you want your input trimmed, see <see cref="ToCode(string)"/>.
        /// </summary>
        public ICode ToCode_WithoutTrim(string value)
        {
            var output = Instances.StringOperator_T0193_Extensions.ToCode(value);
            return output;
        }

        /// <summary>
        /// Trims the input. If you do not want your input trimmed, see <see cref="ToCodeFileContent_WithoutTrim(string)"/>.
        /// </summary>
        public ICodeFileContent ToCodeFileContent(string value)
        {
            var trimmedValue = value.Trim();

            var output = this.ToCodeFileContent_WithoutTrim(trimmedValue);
            return output;
        }

        /// <summary>
        /// Does not trim the input. If you want your input trimmed, see <see cref="ToCodeFileContent(string)"/>.
        /// </summary>
        public ICodeFileContent ToCodeFileContent_WithoutTrim(string value)
        {
            var output = Instances.StringOperator_T0193_Extensions.ToCodeFileContent(value);
            return output;
        }

        /// <summary>
        /// Trims the beginning (but not the end) of the input. If you do not want your input trimmed, see <see cref="ToCodeFileContent_WithoutTrim(string)"/>.
        /// </summary>
        public ICodeFileContent ToCodeFileContent_WithoutTrimEnd(string value)
        {
            var trimmedValue = value.TrimStart();

            var output = this.ToCodeFileContent_WithoutTrim(trimmedValue);
            return output;
        }
    }
}
