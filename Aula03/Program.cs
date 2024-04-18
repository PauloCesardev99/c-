

/*
    NameSpace Definições

    - Enquanto as pastas são as divisões físicas
    -Os namespace são as divisões lógicas
    -Assim como não podemos ter dois arquivos com o mesmo nome nas pastas
    -Não podemos ter duas classes com mesmo nome em um namespace
    -O ideal é ter apenas um namespace e uma classe por arquivo
    -o escopo de um namespace é definido entre Chaves
    -classes e métodos também
    -um namespace pode ser reutilizado
    -Pode estar presente em diversos arquivos.


    Variavel

    -Definições

-Uma variável é algo que utilizamos para armazenar uma informação
-Ser variável significa que seu valor pode ser alterado a qualquer momento
-Ou seja, ele pode variar
-Sempre que "Criamos" uma variável, dizemos que estamos inicializando ela.

-Podemos usar um TIPO ou a palavra reservada "var" para criar uma variável
-Vamos aprender ainda sobre tipo de dados
-No c# o tipo vem sempre antes do nome da varável
-Podemos informar um valor já na criação da varável
-Se não informado o valor padrão será aplicado

int idade; // correto inicia com ZERO
int idade = 25; //Correto inicia com 25
var idade = 25; // Correto inicia com 25
var idade; //errado 

 */
namespace Aula03;
class Program
{
    static void Main(string[] args)
    {
        int idade = 25;
        int primeiroNome = 23;
        Console.WriteLine(idade);
    }
}
