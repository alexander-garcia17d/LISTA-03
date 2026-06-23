using System;
using System.Globalization;

namespace Lista03
{
    public static class Atividades
    {
        public static void MediaNotas()
        {
            double[] notas = new double[5];
            double soma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Informe a nota: ");
                notas[i] = double.Parse(Console.ReadLine()!, CultureInfo.CurrentCulture);
                soma += notas[i];
            }

            double media = soma / notas.Length;
            Console.WriteLine($"Soma das notas: {soma}");
            Console.WriteLine($"Média final: {media}");
        }

        public static void ControleIdadeTurma()
        {
            int[] idades = new int[8];
            int menores = 0, maiores = 0;
            for (int i = 0; i < idades.Length; i++)
            {
                Console.Write("Informe a idade do estudante: ");
                idades[i] = int.Parse(Console.ReadLine()!);
                if (idades[i] < 18) menores++; else maiores++;
            }

            Console.WriteLine($"Quantidade de menores de idade: {menores}");
            Console.WriteLine($"Quantidade de maiores de idade: {maiores}");
        }

        public static void GastosSemana()
        {
            double[] gastos = new double[7];
            double soma = 0;
            double maior = double.MinValue, menor = double.MaxValue;
            for (int i = 0; i < gastos.Length; i++)
            {
                Console.Write("Informe o gasto do dia: ");
                gastos[i] = double.Parse(Console.ReadLine()!, CultureInfo.CurrentCulture);
                soma += gastos[i];
                if (gastos[i] > maior) maior = gastos[i];
                if (gastos[i] < menor) menor = gastos[i];
            }

            double media = soma / gastos.Length;
            Console.WriteLine($"Total gasto na semana: R$ {soma}");
            Console.WriteLine($"Média diária de gastos: R$ {media}");
            Console.WriteLine($"Maior gasto: R$ {maior}");
            Console.WriteLine($"Menor gasto: R$ {menor}");
        }

        public static void HorasEstudo()
        {
            int[] horas = new int[7];
            int total = 0, metaAtingida = 0, metaNao = 0;
            for (int i = 0; i < horas.Length; i++)
            {
                Console.Write("Informe as horas estudadas no dia: ");
                horas[i] = int.Parse(Console.ReadLine()!);
                total += horas[i];
                if (horas[i] >= 2) metaAtingida++; else metaNao++;
            }

            Console.WriteLine($"Total de horas estudadas: {total}");
            Console.WriteLine($"Dias com meta atingida: {metaAtingida}");
            Console.WriteLine($"Dias com meta não atingida: {metaNao}");
        }

        public static void TemperaturasRegistradas()
        {
            double[] temps = new double[6];
            double soma = 0;
            for (int i = 0; i < temps.Length; i++)
            {
                Console.Write("Informe a temperatura registrada: ");
                temps[i] = double.Parse(Console.ReadLine()!, CultureInfo.CurrentCulture);
                soma += temps[i];
            }

            double media = soma / temps.Length;
            int acima = 0;
            double maior = double.MinValue, menor = double.MaxValue;
            foreach (var t in temps)
            {
                if (t > media) acima++;
                if (t > maior) maior = t;
                if (t < menor) menor = t;
            }

            Console.WriteLine($"Média das temperaturas: {media}");
            Console.WriteLine($"Dias acima da média: {acima}");
            Console.WriteLine($"Maior temperatura: {maior}");
            Console.WriteLine($"Menor temperatura: {menor}");
        }

        public static void AnaliseNumerosInteiros()
        {
            int[] nums = new int[10];
            int positivos = 0, negativos = 0, zeros = 0, pares = 0, impares = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("Informe um número inteiro: ");
                nums[i] = int.Parse(Console.ReadLine()!);
                if (nums[i] > 0) positivos++;
                else if (nums[i] < 0) negativos++;
                else zeros++;
                if (nums[i] % 2 == 0) pares++; else impares++;
            }

            Console.WriteLine($"Quantidade de positivos: {positivos}");
            Console.WriteLine($"Quantidade de negativos: {negativos}");
            Console.WriteLine($"Quantidade de zeros: {zeros}");
            Console.WriteLine($"Quantidade de pares: {pares}");
            Console.WriteLine($"Quantidade de ímpares: {impares}");
        }

        public static void ProdutosEPrecos()
        {
            string[] nomes = new string[5];
            double[] precos = new double[5];
            double soma = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Informe o nome do produto: ");
                nomes[i] = Console.ReadLine()!;
                Console.Write("Informe o preço do produto: ");
                precos[i] = double.Parse(Console.ReadLine()!, CultureInfo.CurrentCulture);
                soma += precos[i];
            }

            int idxMax = 0, idxMin = 0;
            for (int i = 1; i < precos.Length; i++)
            {
                if (precos[i] > precos[idxMax]) idxMax = i;
                if (precos[i] < precos[idxMin]) idxMin = i;
            }

            Console.WriteLine($"Produto mais caro: {nomes[idxMax]}");
            Console.WriteLine($"Preço do produto mais caro: R$ {precos[idxMax]}");
            Console.WriteLine($"Produto mais barato: {nomes[idxMin]}");
            Console.WriteLine($"Preço do produto mais barato: R$ {precos[idxMin]}");
            Console.WriteLine($"Total dos preços: R$ {soma}");
        }

        public static void PesquisaPreferencia()
        {
            int[] votos = new int[12];
            int pizza = 0, hamburguer = 0, pastel = 0;
            for (int i = 0; i < votos.Length; i++)
            {
                Console.Write("Informe o voto do estudante: ");
                votos[i] = int.Parse(Console.ReadLine()!);
                if (votos[i] == 1) pizza++;
                else if (votos[i] == 2) hamburguer++;
                else if (votos[i] == 3) pastel++;
            }

            Console.WriteLine($"Votos para Pizza: {pizza}");
            Console.WriteLine($"Votos para Hambúrguer: {hamburguer}");
            Console.WriteLine($"Votos para Pastel: {pastel}");
        }

        public static void ListaTarefas()
        {
            string[] tarefas = new string[5];
            int[] prioridades = new int[5];
            int baixa = 0, media = 0, alta = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Informe o nome da tarefa: ");
                tarefas[i] = Console.ReadLine()!;
                Console.Write("Informe a prioridade da tarefa: ");
                prioridades[i] = int.Parse(Console.ReadLine()!);
                if (prioridades[i] == 1) baixa++;
                else if (prioridades[i] == 2) media++;
                else if (prioridades[i] == 3) alta++;
            }

            Console.WriteLine($"Tarefas de baixa prioridade: {baixa}");
            Console.WriteLine($"Tarefas de média prioridade: {media}");
            Console.WriteLine($"Tarefas de alta prioridade: {alta}");
            Console.WriteLine("Tarefas de alta prioridade:");
            for (int i = 0; i < 5; i++)
            {
                if (prioridades[i] == 3) Console.WriteLine($"- {tarefas[i]}");
            }
        }

        public static void BuscaEstudante()
        {
            string[] nomes = new string[8];
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Informe o nome do estudante: ");
                nomes[i] = Console.ReadLine()!;
            }

            Console.Write("Informe o nome para busca: ");
            string buscado = Console.ReadLine()!;
            int indice = Array.IndexOf(nomes, buscado);
            if (indice >= 0)
            {
                Console.WriteLine($"Estudante encontrado na posição {indice + 1}.");
            }
            else
            {
                Console.WriteLine("Estudante não encontrado.");
            }
        }
    }
}
