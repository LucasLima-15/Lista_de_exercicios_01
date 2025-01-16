/*
Ex.09 - Dia da semana (usando if-else)

 
Objetivo: Pratique o uso de várias condições com if, else if e else. 
Descrição: Desenvolva um programa que solicite um número de 1 a 7 e exiba o dia da semana correspondente (1 para "domingo", 2 para "segunda-feira", etc.). Se o número estiver fora desse intervalo, exiba uma mensagem de erro. 
Exemplo de saída: "Domingo", "Segunda-feira", etc., ou "Número inválido. Digite um número de 1 a 7."
   */

Console.WriteLine("Digite um número entre 1 a 7");
int num = int.Parse(Console.ReadLine());

if (num == 1)
    Console.WriteLine("Domingo");

else if (num == 2)
    Console.WriteLine("Segunda-feira");

else if (num == 3)
    Console.WriteLine("Terça-feira");

else if (num == 4)
    Console.WriteLine("Quarta-feira");

else if (num == 5)
    Console.WriteLine("Quinta-feira");

else if (num == 6)
    Console.WriteLine("Sexta-feira");

else if (num == 2)
    Console.WriteLine("Sabado");

else
    Console.WriteLine("Número inválido");