/*
Ex.06 -Classificação de notas

 
Objetivo: Aprenda a usar várias condições em uma estrutura de decisão. 
Descrição: Crie um programa que solicite a nota de um aluno e classifique a nota em categorias: "Excelente" (nota >= 9), "Bom" (7 <= nota < 9), "Regular" (5 <= nota < 7) e "Baixo" (nota < 5). Exiba a classificação na tela. 
Saída de amostra: "Excelente", "Bom", "Razoável" ou "Baixo".
   */
Console.WriteLine("Digite o seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("Digite a sua nota:");
float nota  = float.Parse(Console.ReadLine());

if (nota <= 5)
    Console.WriteLine($"A nota do {nome} é baixa");

else if (nota <= 7)
    Console.WriteLine($"A nota do {nome} é regular");

else if (nota <= 9)
    Console.WriteLine($"A nota do {nome} é execelente");

