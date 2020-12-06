using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace MySourceGenerator.SyntaxReceivers
{
    public class OtherSyntaxReceiver : ISyntaxReceiver
    {
        public ClassDeclarationSyntax OtherClassSyntax { get; private set; }

        public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
        {
            if (syntaxNode is ClassDeclarationSyntax classSyntax &&
                classSyntax.Identifier.ValueText == "OtherClass")
            {
                OtherClassSyntax = classSyntax;
            }
        }

    }
}