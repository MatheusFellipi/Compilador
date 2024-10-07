using Compilador.Enum;

namespace Compilador
{
    public class Token
    {
        public EnumTokenTipo Nome; 
        
        public string Lexema;

        public Token(EnumTokenTipo nome, String lexema)
        {
            this.Nome = nome; this.Lexema = lexema;
        }
    }
}
