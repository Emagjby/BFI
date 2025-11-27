using System.IO;
using BFI.Lexing;
using BFI.Parsing;

namespace BFI;

class Program
{
    public static void Main(string[] args)
    {
        // Source file
        var source = File.ReadAllText(args[0]);

        // Tokenize input
        var tokenizer = new Tokenizer(source);
        var tokens = tokenizer.Tokenize();

        // Parsing tokens into operations
        var parser = new Parser(tokens);
        var ast = parser.Parse();

        // Executing operations
        var ctx = new AST.ExecutionContext();
        foreach (var node in ast)
        {
            node.Execute(ctx);
        }
    }
}
