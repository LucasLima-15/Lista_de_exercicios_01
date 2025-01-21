/*
Ex.03 -Aprovação do aluno

 
Objetivo: Compreender a aplicação das condições para a tomada de decisão. 
Descrição: Escreva um programa que solicite a nota de um aluno. Se a nota for maior ou igual a 6, o aluno é considerado "Aprovado". Caso contrário, ele está "falhando". Exiba a situação do aluno na tela. 
Exemplo de saída: "Aluno aprovado." ou "Aluno reprovado".
   */
Console.WriteLine("Digite o seu nome:");
string nome  = Console.ReadLine();

Console.WriteLine("Digite a sua nota (entre 0 a 10):");
float nota  = float.Parse(Console.ReadLine());

if (nota <= 10)
    if (nota >= 6)
        Console.WriteLine($"O aluno {nome} foi aprovado");

    else
        Console.WriteLine($"O aluno {nome} foi reprovado");
else
    Console.WriteLine("Nota inválida");