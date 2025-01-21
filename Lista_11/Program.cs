/*
// Ex - 11 - Crie um programa que peça ao usuário para inserir um número inteiro positivo e então conte de 1 até esse número, exibindo cada número. O programa deve implementar essa contagem usando while, do while e for.
 */
/*Usando WHILE*/
Console.WriteLine("Digite um número inteiro: ");
int num = Convert.ToInt32(Console.ReadLine());
int contador = 1;

Console.WriteLine("while");
while (contador <= num)
{
    Console.WriteLine(contador);
    contador++;
}

/*Usando FOR*/
Console.WriteLine("for");
for (int conta = 1; conta <= num; conta++)
{
    Console.WriteLine(conta);
}

/*Usando DO*/
Console.WriteLine("do");
int contador_do = 1;

do
{
    Console.WriteLine(contador_do);
    contador_do++;
}
while (contador_do <= num);