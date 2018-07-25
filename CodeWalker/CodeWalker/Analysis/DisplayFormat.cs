using Microsoft.CodeAnalysis;

namespace CodeWalker.Analysis
{
    internal class ConsoleSymbolDisplayFormat
    {
        internal readonly static SymbolDisplayFormat Format = new SymbolDisplayFormat(
            SymbolDisplayGlobalNamespaceStyle.Omitted,
            SymbolDisplayTypeQualificationStyle.NameOnly,
            SymbolDisplayGenericsOptions.IncludeVariance,
            SymbolDisplayMemberOptions.IncludeParameters | SymbolDisplayMemberOptions.IncludeType,
            SymbolDisplayDelegateStyle.NameAndParameters,
            SymbolDisplayExtensionMethodStyle.Default,
            SymbolDisplayParameterOptions.IncludeExtensionThis | SymbolDisplayParameterOptions.IncludeParamsRefOut | SymbolDisplayParameterOptions.IncludeType,
            SymbolDisplayPropertyStyle.ShowReadWriteDescriptor,
            SymbolDisplayLocalOptions.IncludeType,
            SymbolDisplayKindOptions.IncludeMemberKeyword,
            SymbolDisplayMiscellaneousOptions.None);
    }
}
