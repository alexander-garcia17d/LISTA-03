// QUESTÃO 1: Média de notas

double[] notas = new double[5];
double soma = 0;

// Preenchimento do vetor
for (int i = 0; i < 5; i++)
{
    Console.Write("Informe a nota: ");
    notas[i] = double.Parse(Console.ReadLine());
    soma += notas[i];
}

// Cálculo da média
double media = soma / 5;

// Saída com vírgula como separador decimal
Console.WriteLine($"Soma das notas: {soma.ToString().Replace(".", ",")}");
Console.WriteLine($"Média final: {media.ToString().Replace(".", ",")}");
