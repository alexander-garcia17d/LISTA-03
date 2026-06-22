// Questão 2: Controle de idade da turma

int[] idades = new int[5];
int menores = 0;
int maiores = 0;

// Preenchimento do vetor e contagem
for (int i = 0; i < 8; i++)
{
    Console.Write("Informe a idade do estudante: ");
    idades[i] = int.Parse(Console.ReadLine()!);

    if (idades[i] < 18)
    {
        menores++;
    }
    else
    {
        maiores++;
    }
}

// Saída
Console.WriteLine($"quantidade de menores de idade: {menores}");
Console.WriteLine($"quantidade de maiores de idade: {maiores}");
