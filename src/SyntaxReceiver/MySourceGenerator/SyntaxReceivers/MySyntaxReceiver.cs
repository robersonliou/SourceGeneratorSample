using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace MySourceGenerator.SyntaxReceivers
{
    public class MySyntaxReceiver : ISyntaxReceiver
    {
        public ClassDeclarationSyntax MyClassSyntax { get; private set; }

        public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
        {
            if (syntaxNode is ClassDeclarationSyntax classSyntax)
            {
                var identifierValueText = classSyntax.Identifier.ValueText;
                if (identifierValueText == "MyClass")
                {
                    MyClassSyntax = classSyntax;
                }
            }
        }
    }
}