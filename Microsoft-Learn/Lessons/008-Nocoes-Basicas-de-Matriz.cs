/* 
    Declarando e atribuindo valores em uma Matriz.
    O primeiro indice de uma matriz é 0.
*/

string[] fraudulentOrderIDs = new string[3];
// O operador new cria uma nova instância de uma matriz tipo string 
// que pode conter três valores tipo cadeia de caracteres e armazena na memória.

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// Atribui valores para cada item da matriz. 

fraudulentOrderIDs[3] = "D000";
// Retorna um erro de compilação ao tentar acessar um indice que não existe na matriz.

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Exibe o valor do primeiro elemento da matriz

fraudulentOrderIDs[0] = "F000";
// Reatribui um valor ao primeiro elemento da matriz.

string[] fraudulentOrderIDs = {"A123", "B456", "C789" };
// Inicializa e definie os valores de uma matriz.

Console.WriteLine(fraudulentOrderIDs.Length);
// Retorna o número de elementos de uma matriz.

/*
    Percorrendo os elementos de uma Matriz
    Instrução foreach
*/
string[] names = {"Bianca", "Elisa", "Tarcisio" };
// Inicializa a matriz names com os elementos informados.
foreach (string name in names)
{
    Console.WriteLine(name);
}
// Itera os elemetos da matriz, armazena o valor do elemento na string name,
// e executa o bloco de código entre colchetes.

int[] inventory = { 200, 450, 700, 175, 250 };
// Inicializa uma matriz de inteiros.
int sum = 0;
// Inicializa uma variável para armazenzar a soma dos valores dos elementos.
foreach (int items in inventory)
{
    sum += items;
}
Console.WriteLine($"We have {sum} items in invetory.");
// Itera os elementos da matriz, realiza a soma dos elementos e imprime o resultado.

int[] inventory = { 200, 450, 700, 175, 250 };
// Inicializa uma matriz de inteiros.
int sum = 0;
// Inicializa uma variável para armazenzar a soma dos valores dos elementos.
int bin = 0;
// Inicializa uma variável para armazenzar o indice do elemento atual.
foreach (int items in inventory)
{
    sum += items;
    bin++;
    // incrementa a variável a cada iteração
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
    // Exibe o indice e o valor do elemento atual e a soma dos elementos.
}
Console.WriteLine($"We have {sum} items in invetory.");

/*
    Utilizando o método StartsWith
*/
string[] fraudulentOrderIDs = {"B123","C234","A345","C15","B177","G3003","C235","B179"};
foreach (string id in fraudulentOrderIDs)
{
    if ( id.StartsWith("B") )
    {
        Console.WriteLine(id);
    }
}
// Imprime somente os elementos cujo primeiro caracter é a letra "B".


