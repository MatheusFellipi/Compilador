using Compilador.Enum;

namespace Compilador.Lexima
{
    public class Token(EnumTokenTipo tipo, string valor)
    {
        public EnumTokenTipo Tipo = tipo;

        public string Valor = valor;

        public override string ToString()
        {
            return $"/{Tipo}, {Valor}\\";
        }
    }
}
