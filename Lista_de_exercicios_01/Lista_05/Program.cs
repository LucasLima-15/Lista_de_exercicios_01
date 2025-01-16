/*
Ex.05 -Verificação de idade

 
Objetivo: Aplicar condições para classificar os dados. 
Descrição: Desenvolva um programa que pergunte a idade de uma pessoa e determine se ela é maior de idade (18 anos ou mais) ou menor de idade. Use if e else para exibir a mensagem apropriada. 
Exemplo de saída: "Você é maior de idade." ou "Você é menor de idade".
   */
Console.WriteLine("Digite o seu nome");
string nome  = Console.ReadLine();

Console.WriteLine("Digite a sua idade");
int idade = int.Parse(Console.ReadLine());

if (idade >= 0)
    if (idade >= 18)
        Console.WriteLine($"O {nome} é maior de idade");

    else
        Console.WriteLine($"O {nome} é menor de idade");

else
    Console.WriteLine("Idade invalida");