Console.WriteLine('a');
//imprime um char(caractere), retorna erro caso seja informado uma cadeia de caracteres

Console.WriteLine("Hello Word");
//imprime uma cadeia de caracteres, retorna erro caso seja utilizada aspas simples.

Console.WriteLine(123);
//retorna um literal int(inteiro)

Console.WriteLine(12.3m);
//retorna um letral decimal - a letra "m" indica ao compilador que o valor é do tipo decimal.

Console.WriteLine(true);
//retorna um literal booleano(bool) - diferente de Console.WriteLine("true")

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

string firstName;
//cria uma váriavel do tipo string

firstName = "Bob";
//atribui um valor a variável. - As atribuições dever ser da direita para a esquerda.

string value = "Bob";
//inicializa uma várial

/* 
Variáveis de tipo implicito
- São declaradas utilizando a palavra-chave "var".
- "var" só podera ser utilizada se a variável for inicializada. 
*/

var message = "Hello world!";
//inicializa a variável e define o tipo como string

var tem = 30.1m;
//inicializa uma variável e define o tipo como decimal