namespace Compilador.Enum
{
    public enum EnumTokenTipo
    {
        Valor,                      // Representa um número (como o valor 1)
        IdentificadorTabela,          // Representa o nome da tabela
        IdentificadorTabelaAtributos, // Representa o atributo da tabela
        Eof,                         // Fim da consulta (End Of File)

        PesquisaSelecione,       // Representa o comando "Selecione"
        PesquisaQuePossui,       // Representa o comando "que possui" (equivalente ao WHERE)
        PesquisaOrdenadoPor,     // Representa "ordenado por" (equivalente ao ORDER BY)
        PesquisaAgrupadoPor,     // Representa "agrupar por" (equivalente ao GROUP BY)
        PesquisaConte,           // Representa "Conte" (equivalente ao COUNT)
        PesquisaSomar,            // Representa "Somar" (equivalente ao SUM)


        OprLogCompIgualA,        // Representa "é" ou "igual a" (equivalente ao operador =)
        OprLogCompMaiorQue,      // Representa "maior que" (equivalente ao operador >)
        OprLogCompMenorQue,      // Representa "menor que" (equivalente ao operador <)
        OprLogCompDiferenteDe,   // Representa "diferente de" (equivalente ao operador !=)
        OprLogCompContem,        // Representa "contém" (equivalente ao LIKE %valor%)
        OprLogCompComecaCom,     // Representa "começa com" (equivalente ao LIKE valor%)
        OprLogCompMenorIgual,    // Representa o operador "<="
        OprLogCompMaiorIgual,    // Representa o operador ">="

        OprE,           // Representa "e" (equivalente ao operador AND)
        OprOu,          // Representa "ou" (equivalente ao operador OR)
        OprLogE,        // Representa o operador "AND" "&&" "E"
        OprLogOu,       // Representa o operador "OR" "||" "OU"
        OprLogNao       // Representa o operador "NOT" "!" "Ñ" "NAO"
    }
}