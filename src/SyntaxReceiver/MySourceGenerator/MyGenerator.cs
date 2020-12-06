using System.Diagnostics;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MySourceGenerator.SyntaxReceivers;

namespace MySourceGenerator
{
    [Generator]
    public class MyGenerator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
            //Enagle to manually attach debugger.
            Debugger.Launch();

            context.RegisterForSyntaxNotifications(() => new MySyntaxReceiver());

            //Throw exception caused it's only allowed implementing single syntax recevier.
            //context.RegisterForSyntaxNotifications(() => new OtherSyntaxReceiver());
        }

        public void Execute(GeneratorExecutionContext context)
        {
            if (context.SyntaxReceiver is MySyntaxReceiver mySyntaxReceiver)
            {
                ClassDeclarationSyntax classSyntax = mySyntaxReceiver.MyClassSyntax;
            }
        }
    }
}