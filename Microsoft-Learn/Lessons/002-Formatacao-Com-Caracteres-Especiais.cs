/*  Utilizando sequencia de escape de caracteres */

Console.WriteLine("Hello\nWorld!");
// { "\n" } Imprime com uma quebra de linha entre Hello e World!...
// Hello
// World!

Console.WriteLine("Hello\nWorld!");
// { \t } Imprime com uma tabulação entre Hello e World!...
// Hello   World!

Console.WriteLine("Hello \"World\"!");
// { \" } Permite imprimir a palavra World entre aspas...
// Hello "World"!

Console.WriteLine("c:\\source\\repos");
// { \\ } Permite imprimir uma barra invertida entre as palavras - Uma barra invertida é reservada para no C#
// c:\source\repos

Console.WriteLine(@"    c:\source\repos
        (this is where your code goes)");
// { @ } permite manter os espaços e tabulações e a utilização de barra invertida simples
//   c:\source\repos   
//      (this is where your code goes)

Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
// { \u } permite a utilização de caracteres Unicode
// こんにちは World!

