/*
Objetivo: Pratique a comparação de variáveis. 
Descrição: Escreva um programa que solicite ao usuário dois números e determine qual é o maior. Use if, else if e else para exibir a mensagem apropriada. 
Exemplo de saída: "O primeiro número é maior.", "O segundo número é maior." ou "Os números são iguais.
 */

Console.WriteLine("Digite um número:");
int n1 = int.Parse (Console.ReadLine());



if (n1 % 2 == 0)
    Console.WriteLine("O número que você digitou é par");

else
    Console.WriteLine("O número que você digitou é ínpar");