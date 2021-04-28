/* 
Nomes de váriáveis
    - Não podem conter caractetres especiais #, - e $
    - Devem iniciar com uma letra ou sublinhado.
    - O c# diferencia maiusculas e minusculas.
    - Os nomes de variável devem usar o camel case. Ex; string thisIsCamelCase
    - Escolher um nome para a variável que represente o tipo de dados que ela manterá.
    - Não utilizar contrações.
    - Não incluir o tipo de dados no nome da variável. Ex; strString
*/

/*
Comentários no código
    - Utilizar quando precisar testar outra abordagem, porém não deseja apagar o codigo atual
    - Adcionar uma mensagem ToDo, para lebrar das partes do codigo que deseja rever.
    - Evitar comentar o que cada metodo esta fazendo, sem que isto ajude a entender o propósito do codigo.
    --> Muitas vezes, os desenvolvedores atualizam o código mas esquecem de atualizar os comentários.
*/

string firstName = "Bob";
int widgetsPurchased = 7;
// Testing a change to the message.
// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
// Comentário usados para alterar temporáriamente o codigo, possibilitando
// voltar ao condigo anterior caso a nova abordagem não atenda.


// --> Exemplo de comentários de baixa qualidade
Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, padd with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
//

/*
    Utilizando Espaço em Branco
    - O compilador do C# ignora os espaços em branco.
    - Utilizar uma linha para cada instrução.
    - Quebrar a linha somente quando o código da intrução estiver muito longo.
    - Uma atribuição deve estar entre espaços em branco.
*/

// --> Exemplo de como utilizar o espaço em branco para facilitar a leitura do codigo.
// Código sem nenhuma separação...
Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
if ((roll1 == roll2) && (roll2 == roll3)){
    Console.WriteLine("You rolled triples!  +6 bonus to total!");
    total += 6;
}
else{
    Console.WriteLine("You rolled doubles!  +2 bonus to total!");
    total += 2;
}
}

/*
    Utilizando linhas em branco para facilitar a leitura;
    - Adcionada uma linha em branco para separar o instanciamento do método Random.
    - Adcionada uma linha em branco para separar a declaração das variáveis.
    - Adcionada uma linha em branco para separar o armazenamento e exibição do resultado do cálculo.
    - Dentro da instrução if, as chaves de abertura de cada bloco foram colocadas em uma linha.
    - Utilizado tabulação(tecla tab) para alinhas os blocos dentro da instução if.
*/
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}


/*
    Exemplo de melhores práticas para nomes de variáveis
    e para utilização de espaços
*/
// --> Código original...

string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");

/* --> Código mais legivel...
    - Alterado o nome da variável str para o padrão camell case, originalMessage.
    - Retirada a declaração de tipo de variável no nome da variável message.
    - Alterado o nome da variável x para um nome mais indicativo, letterCount.
    - Alterado o nome da variável i para um nome mais indicativo, letter.
    - Alinhamento em bloco na instrução foreach.
    - Retirado caracter "_" desnecessário da variável new_message.
    - Acrescentadas linhas em branco para dividir melhor cada etapa do código.
*/

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;
foreach (char letter in message)
{
    if (letter == 'o') 
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);

Console.WriteLine($"'o' appears {letterCount} times.");