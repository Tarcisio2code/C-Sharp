/* 
    Ao utilizarmos o simbolo "+" entre uma string e um valor int, o compilador C# entente
    que desejamos concatenar os dois valores e converte temporariamente o int em string
    para realizar a concatenação.

    O operador parênteses() pode ser utilizado como sobrecarga de invocação de método, ordem de operações e conversão
*/
string firstName = "Bianca";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
// Retorna a concatenação entre a variavel string, as cadeias de caracteres e a variavel int.
// Bianca sold 7 widgets.

string firstName = "Bianca";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
// Mesmo incluindo um literal int "7", o compilador não realiza a soma, tudo é tratado como uma cadeia de caracteres.
// Bianca sold 77 widgets.

string firstName = "Bianca";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
// Para realizarmos a operação de soma, devemos acrescentar os parenteses, onde o compilador irá realizar primeiro a fórmula e depois a concatenação.
// O ideal no entanto seria realizar a operação matemática antes da concatenação.
// Bianca sold 14 widgets.

int quotient = 7 / 5;
Console.WriteLine("Quotient: " + quotient);
// Como a variável foi definida como inteiro, o resultado não será apresentado com casas decimais.
// Quotient: 1

decimal decinalQuotient = 7.0m / 5;
Console.WriteLine("Quotient: " + decinalQuotient);
// Para obter o resultado com casas decimais, precisamos declarar a variável como decimal, e um dos números como decimal.
// Quotient: 1.4

Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5));
// Utilizamos o operador % para obtermos o resto de uma divisão.
// Caso o retorno for 0, sabemos que o dividendo é divisível pelo divisor.
// Modulus of 200 / 5 : 0

/* 
    Ordem de operações em C#
    As operações matemáticas são executadas de forma semelhante ao acronimo PEMDAS;

    1º Parênteses(), 2º Multiplicação*, 3º Divisão/, 4º Adição+, 5º Subtração-.
*/

int value1 = 3 + 4 * 5;
Console.WriteLine(value1);
// Seguindo a ordem, o compilador do c# irá primeiro realizar a multiplicação e depois a soma;
// 23

int value2 = (3 + 4) * 5;
Console.WriteLine(value2);
// Porém quando adcionamos os parenteses, o compilador realizar primeiro a operação que esta dentro deles;
// 35

/* 
    Incrementar e decrementar valores
    Os operadores +=, -=, *=, ++ e -- são conhecidos como operadores de atribuição composta
*/
int value = 0;
value += 5;
// O operador += adiciona e atribui o valor à direita do operador ao valor à esquerda do operador..

int value = 0;
value++;
// O operador ++ incrementa em uma (1) unidade o valor da variável

// A posição dos Operadores retorna valores deferentes
// Quando o operador é informado antes, a operação é realizada antes de recuperar o valor, 
// quando o operador é informado depois a operação também será realizada depois de recuperar o valor.

int value = 1;
value++;
// incrementa um ao valor da variável value
Console.WriteLine("First: " + value);
// exibe o valor atual da variável value
Console.WriteLine("Second: " + value++);
// exibe o valor atual da variável value e faz o incremento
Console.WriteLine("Third: " + value);
// exibe o novo valor da variável value
Console.WriteLine("Fourth: " + (++value));
// incrementa um ao valor da variável value e exibe o resultado

/* 
    Conversão de tipos de dados
*/

int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);
// Para converter o tipo de dado, devemos informar o tipo de dado entre parenteses antes da variável.
// 1.4

/* 
    Exemplo de conversão de dados
    Converter fahrenheit em celsius
    Formula da conversão: subtrair 32 do valor e depois multiplicar por cino nonos(5/9)
*/
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
// para obter o resultado em decimal devemos informar os valores em decimal (seguidos de m).
Console.WriteLine("The temperature is " + celsius + " Celsius.");
// The temperature is 34.444444444444444444444444447 Celsius.