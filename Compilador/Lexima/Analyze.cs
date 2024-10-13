using Compilador.Enum;
using Compilador.Interfaces;

namespace Compilador.Lexima
{
    public class Analyze(IReadFile readFile)
    {
        private readonly IReadFile _ReadFile = readFile;

        public Token ToAnalyzeChar()
        {
            int CaractereLido = -1;
            while ((CaractereLido = _ReadFile.NextChar()) != -1)
            {
                char c = (char)CaractereLido;
                switch (c)
                {
                    case ':':
                        return new Token(EnumTokenTipo.PesquisaSelecione, ":");
                    case '+':
                        return new Token(EnumTokenTipo.OprLogCompIgualA, "+");
                    case '>':
                        c = (char)_ReadFile.NextChar();
                        if (c == '=')
                            return new Token(EnumTokenTipo.OprLogCompMaiorIgual, ">=");
                        else
                            _ReadFile.Rewind(); 
                        return new Token(EnumTokenTipo.OprLogCompMaiorQue, ">");
                    case '<':
                        c = (char)_ReadFile.NextChar();
                        if (c == '>')
                            return new Token(EnumTokenTipo.OprLogCompDiferenteDe, "<>");
                        else if (c == '=')
                            return new Token(EnumTokenTipo.OprLogCompMenorIgual, "<=");
                        else
                            _ReadFile.Rewind(); 
                        return new Token(EnumTokenTipo.OprLogCompMenorQue, "<");
                    case '=':
                        return new Token(EnumTokenTipo.OprLogCompIgualA, "=");
                    case '&':
                        c = (char)_ReadFile.NextChar();
                        if (c == '&')
                            return new Token(EnumTokenTipo.OprLogE, "&&");
                        break;
                    case '|':
                        c = (char)_ReadFile.NextChar();
                        if (c == '|')
                            return new Token(EnumTokenTipo.OprLogOu, "||");
                        break;
                    case '!':
                        c = (char)_ReadFile.NextChar();
                        if (c == '=')
                            return new Token(EnumTokenTipo.OprLogCompDiferenteDe, "!=");
                        else
                            _ReadFile.Rewind(); // Voltar um caractere
                        return new Token(EnumTokenTipo.OprLogNao, "!");
                    default:
                        if (char.IsLetter(c))
                        {
                            string palavra = LerPalavra(c);
                            return AnalisarPalavraChave(palavra);
                        }
                        break;
                }
            }

            return new Token(EnumTokenTipo.Eof, "EOF");
        }

        private string LerPalavra(char inicial)
        {
            string palavra = inicial.ToString();
            int CaractereLido;
            while ((CaractereLido = _ReadFile.NextChar()) != -1)
            {
                char c = (char)CaractereLido;
                if (char.IsLetterOrDigit(c))
                {
                    palavra += c;
                }
                else
                {
                    _ReadFile.Rewind();
                    break;
                }
            }
            return palavra;
        }

        private Token AnalisarPalavraChave(string palavra)
        {
            switch (palavra.ToLower())
            {
                case "selecione":
                    return new Token(EnumTokenTipo.PesquisaSelecione, palavra);
                case "que":
                    return new Token(EnumTokenTipo.PesquisaQuePossui, palavra);
                case "ordenado":
                    return new Token(EnumTokenTipo.PesquisaOrdenadoPor, palavra);
                case "agrupar":
                    return new Token(EnumTokenTipo.PesquisaAgrupadoPor, palavra);
                case "conte":
                    return new Token(EnumTokenTipo.PesquisaConte, palavra);
                case "somar":
                    return new Token(EnumTokenTipo.PesquisaSomar, palavra);
                case "e":
                    return new Token(EnumTokenTipo.OprE, palavra);
                case "ou":
                    return new Token(EnumTokenTipo.OprOu, palavra);
                default:
                    return new Token(EnumTokenTipo.IdentificadorTabela, palavra);
            }
        }
    }
}
