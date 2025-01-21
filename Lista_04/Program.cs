/*
Ex.04 -Faixa de valor

 
Objetivo: Familiarizar -se com a verificação de intervalos numéricos. 
Descrição: Crie um programa que verifique se um número inserido pelo usuário está dentro do intervalo de 1 a 100. Use uma condição if para verificar se o número está dentro do intervalo e exiba uma mensagem informando o resultado. 
Exemplo de saída: "O número está entre 1 e 100." ou "O número não está entre 1 e 100."
   */

Console.WriteLine("Digite um número:");
float num  = float.Parse(Console.ReadLine());


if (num > 100)
    Console.WriteLine("O seu número não está entre 1 a 100");

else if (num <= 0)
    Console.WriteLine("O seu número não está entre 1 a 100");

else if (num >= 1 )
    Console.WriteLine("O seu numero está entre 1 a 100");
