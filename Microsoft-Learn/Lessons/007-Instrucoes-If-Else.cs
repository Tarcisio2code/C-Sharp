// Cria uma nova instancia da classe Random e armazena na variável dice
Random dice = new Random();

// Armazena um número aleatório entre 1 e 7 em cada variável
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

// Armazena a somatória das variáveis acima na variável total
int total = roll1 + roll2 + roll3;

// Utiliza a interpolação de caracteres para exibir os numeros randomicos e o total
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// Utiliza a instução condicional "if" e os operadores "or" e "and" para incrementar a variavel total
if ((roll1 == roll2) || roll2 == roll3 || roll1 == roll2 )
{
    if ((roll1 == roll2) && roll2 == roll3 )
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}
if (total >= 15)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}
// Retorno...
// Dice roll: 2 + 2 + 2 = 6
// You rolled triples! +6 bonus to total!
// Sorry, you lose.

/* 
    Utilizando metodos com retorno booleano
*/

// Armazena uma cadeia de caracteres na variável message
string message = "The quick brown fox jumps over the lazy dog.";

// Verifica através do metodo Contain se a variável contem o valor informado
bool result = message.Contains("dog");
// Imprime true or false conforme o resultado do metodo Contains
Console.WriteLine(result);
// Utiliza a instrução "if" condicional para imprimir uma mensagem
if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}
