using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace CodeWalker.Analysis
{
    internal class Saru
    {
        internal static void Analyze(string projectFilePath, string outputFilePath)
        {
            var workspace = MSBuildWorkspace.Create();
            var project = workspace.OpenProjectAsync(projectFilePath).Result;
            var compilation = project.GetCompilationAsync().Result;

            using (var output = new StreamWriter(outputFilePath))
            {
                foreach (var tree in compilation.SyntaxTrees)
                {
                    output.WriteLine(Path.GetFileName(tree.FilePath));
                    output.WriteLine($"  syntax: {tree.GetDiagnostics().Count()}");
                    foreach (var diag in tree.GetDiagnostics())
                    {
                        output.WriteLine($"    {diag}");
                    }

                    output.WriteLine();
                    var semantic = compilation.GetSemanticModel(tree);
                    output.WriteLine($"  semantic: {semantic.GetDiagnostics().Count()}");
                    foreach (var diag in semantic.GetDiagnostics())
                    {
                        output.WriteLine($"    {diag}");
                    }
                    output.WriteLine();

                    var nodes = new Queue<SyntaxNode>();
                    nodes.Enqueue(tree.GetRoot());

                    while (nodes.Count != 0)
                    {
                        var node = nodes.Dequeue();
                        if (node is TypeBlockSyntax)
                        {
                            var typeStatement = node.ChildNodes().First(e => e is TypeStatementSyntax);
                            output.WriteLine("  " + semantic.GetDeclaredSymbol(typeStatement).ToDisplayString());
                            CalcMethodMetric(node.ChildNodes(), semantic, output);
                            output.WriteLine();
                        }

                        foreach (var child in node.ChildNodes())
                        {
                            nodes.Enqueue(child);
                        }
                    }
                }
            }
        }

        private static void CalcMethodMetric(IEnumerable<SyntaxNode> nodes, SemanticModel semantic, TextWriter output)
        {
            foreach (var n in nodes)
            {
                var method = n as MethodBlockSyntax;
                if (method != null)
                {
                    var methodStatement = method.ChildNodes().First(e => e is MethodStatementSyntax);
                    var name = semantic.GetDeclaredSymbol(methodStatement)
                        .ToMinimalDisplayString(semantic, 0, ConsoleSymbolDisplayFormat.Format);

                    var cyclomatic = 1;
                    var ns = new Queue<SyntaxNode>();
                    ns.Enqueue(method);

                    while (ns.Count != 0)
                    {
                        var node = ns.Dequeue();

                        if (CyclomaticCounterUtil.IsCyclomaticCountUpStatement(node))
                        {
                            cyclomatic++;
                        }

                        foreach (var i in node.ChildNodes())
                        {
                            ns.Enqueue(i);
                        }
                    }
                    output.WriteLine($"    {name,-30} {cyclomatic,3}");
                }
            }
        }
    }
}
