/*
Ex.07 -Comparação de números

 
Objetivo: Pratique a comparação de variáveis. 
Descrição: Escreva um programa que solicite ao usuário dois números e determine qual é o maior. Use if, else if e else para exibir a mensagem apropriada. 
Exemplo de saída: "O primeiro número é maior.", "O segundo número é maior." ou "Os números são iguais."
   */

Console.WriteLine("O primeiro número");
float n1  = float.Parse(Console.ReadLine());

Console.WriteLine("O segundo número");
float n2 = float.Parse(Console.ReadLine());

if (n1 != n2)
    if (n1 > n2)
        Console.WriteLine("O primeiro número é maior que o segundo");
    else
        Console.WriteLine("O segundo número é maior que o primeiro");

else
    Console.WriteLine("Os dois número são iguais");