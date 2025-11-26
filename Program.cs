using BFI.Lexing;

namespace BFI;

class Program
{
    public static void Main(string[] args)
    {
        // Test - tokenize console line input
        Tokenizer tokenizer = new Tokenizer(Console.ReadLine()!);
        tokenizer.Tokenize().ForEach(t => Console.WriteLine(t.ToString()));
    }
}
