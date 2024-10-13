

using Compilador.Enum;
using Compilador.Inputs;
using Compilador.Interfaces;
using Compilador.Lexima;

namespace Compilador
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string filePath = "C:\\Users\\mathe\\source\\repos\\Compilador\\Compilador\\Inputs\\Files\\entrada.txt";

            IReadFile readFile = new ReadFile(filePath);
            Analyze analyze = new(readFile);

            analyze.ToAnalyzeChar();

            Token token;
            
            do
            {
                token = analyze.ToAnalyzeChar();
                Console.WriteLine(token.ToString());
            } while (token.Tipo != EnumTokenTipo.Eof);

        }
    }
}