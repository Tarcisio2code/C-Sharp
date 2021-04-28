/* 
    Para acessarmos os metodos de uma bibliteca, precisamos informar os seguintes informações;
    1 - Nome da classe
    2 - Informe o operador de acesso de membro, o símbolo "."
    3 - Informe o nome do método
    4 - Informe o operador de invocação do método, que executa o método, que é um conjunto de parênteses "()"
    5 - Informe, se nescessário os parametros de entrada 

        1   2     3     4       5
    Console . WriteLine ( "Hello World" )

    **Métodos Sem Estado ou Estáticos: não dependem de valores armazenados na memória para funcionar e não afetam uma aplicação
    **Métodos Com Estado ou Instância: dependem de valores armazenados na memória. 
    **Métodos Nulos: executam determinada função sem retornar um valor.
*/

Random dice = new Random();
// Cria uma instancia da bibloteca system.random através do operador "new" e armazena a referencia ao novo objeto na variavel dice
int roll = dice.Next(1, 7);
// Utiliza o método Next instanciado no objeto dice para retrornar um número aleatório e armazenar na variável roll
Console.WriteLine(roll);
// Retora um número aleatório em cada vez que for envicada

int result = Random.Next(1, 7);
// Tentativa de acessar o método direto na classe
// Retorna um erro, informando que é preciso criar um objeto de referência
// error CS0120: An object reference is required

/* Utilizando as versões sobrecarregadas de um método */

Random dice = new Random();
int roll1 = dice.Next();
// Armazena um número aleatório entre 0 e 2.147.483.647, pois não foi passado nenhum parametro
int roll2 = dice.Next(101);
// Armazena um número aleatório entre 0 e 101
int roll3 = dice.Next(50, 101);
// Armazena um número aleatório entre 50 e 101

