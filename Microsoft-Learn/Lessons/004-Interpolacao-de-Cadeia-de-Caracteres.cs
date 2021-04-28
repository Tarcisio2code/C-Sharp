/* 
    Utilizar o símbolo $ para indicar a interpolação cadeias de caracteres.
    As variáveis devem estar entre chaves {}.
*/
string firstName = "Bianca";
string message= $"Hello {firstName}!";
Console.Write(message);
// Exibe a interpolação entre uma cadeia de caracteres e uma variável
// Hello Bianca!

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
// Combina prefixo textual "@" e o símbolo de interpolação "$"
// C:\Output\First-Project\Data

/* Combinado prefixo textual "@", interpolação "$", caracteres de escape "\n,\t" e unicode "\u" */
string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
// View English output:
//         c:\Exercise\ACME\data.txt
//
// Посмотреть русский вывод:
//         c:\Exercise\ACME\ru-RU\data.txt

/* minha solução, reduzindo as variáveis */
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine($@"View English output:
        c:\Exercise\{projectName}\data.txt{"\n"}");
Console.WriteLine($@"{russianMessage}:
        c:\Exercise\{projectName}\ru-RU\data.txt");