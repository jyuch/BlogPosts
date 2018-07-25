namespace CodeWalker.Analysis
{
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.VisualBasic;
    
    internal static class CyclomaticCounterUtil
    {
        internal static bool IsCyclomaticCountUpStatement(SyntaxNode node)
        {
            if (node.Kind() == SyntaxKind.GoToStatement) return true;
            if (node.Kind() == SyntaxKind.ContinueWhileStatement) return true;
            if (node.Kind() == SyntaxKind.ContinueDoStatement) return true;
            if (node.Kind() == SyntaxKind.ContinueForStatement) return true;
            if (node.Kind() == SyntaxKind.SingleLineIfStatement) return true;
            if (node.Kind() == SyntaxKind.IfStatement) return true;
            if (node.Kind() == SyntaxKind.ElseIfStatement) return true;
            if (node.Kind() == SyntaxKind.ErrorStatement) return true;
            if (node.Kind() == SyntaxKind.OnErrorGoToZeroStatement) return true;
            if (node.Kind() == SyntaxKind.OnErrorGoToMinusOneStatement) return true;
            if (node.Kind() == SyntaxKind.OnErrorGoToLabelStatement) return true;
            if (node.Kind() == SyntaxKind.OnErrorResumeNextStatement) return true;
            if (node.Kind() == SyntaxKind.ResumeStatement) return true;
            if (node.Kind() == SyntaxKind.ResumeLabelStatement) return true;
            if (node.Kind() == SyntaxKind.ResumeNextStatement) return true;
            if (node.Kind() == SyntaxKind.SelectStatement) return true;
            if (node.Kind() == SyntaxKind.CaseStatement) return true;
            if (node.Kind() == SyntaxKind.CaseElseStatement) return true;
            if (node.Kind() == SyntaxKind.WhileStatement) return true;
            if (node.Kind() == SyntaxKind.ForStatement) return true;
            if (node.Kind() == SyntaxKind.ForEachStatement) return true;
            if (node.Kind() == SyntaxKind.SimpleDoStatement) return true;
            if (node.Kind() == SyntaxKind.DoWhileStatement) return true;
            if (node.Kind() == SyntaxKind.DoUntilStatement) return true;
            if (node.Kind() == SyntaxKind.SimpleLoopStatement) return true;
            if (node.Kind() == SyntaxKind.LoopWhileStatement) return true;
            if (node.Kind() == SyntaxKind.LoopUntilStatement) return true;
            return false;
        }
    }
}
