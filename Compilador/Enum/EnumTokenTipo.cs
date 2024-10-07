namespace Compilador.Enum
{
    public enum EnumTokenTipo
    {
        // Operadores de comparação
        OprLogIgual,      // Representa o operador "="
        OprLogDiff,       // Representa o operador "!=" ou "<>"
        OprLogMenor,      // Representa o operador "<"
        OprLogMaior,      // Representa o operador ">"
        OprLogMenorIgual, // Representa o operador "<="
        OprLogMaiorIgual, // Representa o operador ">="

        // Operadores lógicos
        OprLogE,          // Representa o operador "AND" "&&" "E"
        OprLogOu,         // Representa o operador "OR" "||" "OU"
        OprLogNao,        // Representa o operador "NOT" "!" "Ñ" "NAO"

        // Operadores de atribuição
        OprAtribuicao,    // Representa o operador "=" para atribuição

        // Operadores aritméticos
        OprAritSoma,      // Representa o operador "+"
        OprAritSubtracao, // Representa o operador "-"
        OprAritMultiplicacao, // Representa o operador "*"
        OprAritDivisao,   // Representa o operador "/"

        // Outros operadores
        OprLike,          // Representa o operador "LIKE" usado para padrões
        OprIn,            // Representa o operador "IN" usado para listas
        OprBetween,

        // Palavras-Chaves
        PesquisaSelect,
        PesquisaFrom,
        PesquisaWhere,

        // Identificadores (números, nomes de tabelas, etc.)
        Identificador, // Representa nomes de tabelas, colunas ou outros identificadores
        Numero,        // Representa um número (como o valor 1)

        // Fim da consulta
        Eof            // Fim da consulta (End Of File)
    }
}
