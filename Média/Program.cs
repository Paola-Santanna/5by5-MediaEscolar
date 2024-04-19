/* 2.Faça um algorítmo que leia dois números reais. 
 * Calcule a sua média e informe a situação do aluno, baseado nos seguintes critérios:
- se a média for <= 3, o aluno está reprovado;
- se for > 3 ou <= 5 , o aluno está de exame;
- senão, ele está aprovado */

float nota_1, nota_2, media;

Console.WriteLine("Calcular a Média - Aprovação, Reprovação ou Exame\n");
Console.WriteLine("Digite a nota 1: ");
nota_1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota 2: ");
nota_2 = float.Parse(Console.ReadLine());

media = (nota_1 + nota_2) / 2;

if (media <= 3) {
    Console.WriteLine($"\nA sua média é {media} \nVocê está REPROVADO!");
}
else if (media > 3 && media <= 5 ) {
    Console.WriteLine($"\nA sua média é {media} \nVocê está de EXAME!");
}
else
{
    Console.WriteLine($"\nA sua média é {media} \nVocê está APROVADO!");
}