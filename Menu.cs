using System;

namespace Lista03
{
    public static class Menu
    {
        public static void Mostrar()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== MENU PRINCIPAL =====");
                Console.WriteLine("1 - Média de notas");
                Console.WriteLine("2 - Controle de idade da turma");
                Console.WriteLine("3 - Gastos da semana");
                Console.WriteLine("4 - Horas de estudo");
                Console.WriteLine("5 - Temperaturas registradas");
                Console.WriteLine("6 - Análise de números inteiros");
                Console.WriteLine("7 - Produtos e preços");
                Console.WriteLine("8 - Pesquisa de preferência");
                Console.WriteLine("9 - Lista de tarefas");
                Console.WriteLine("10 - Busca de estudante");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                var entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out int opcao))
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida.");
                    Console.WriteLine();
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Programa encerrado.");
                        return;
                    case 1:
                        Atividades.MediaNotas();
                        break;
                    case 2:
                        Atividades.ControleIdadeTurma();
                        break;
                    case 3:
                        Atividades.GastosSemana();
                        break;
                    case 4:
                        Atividades.HorasEstudo();
                        break;
                    case 5:
                        Atividades.TemperaturasRegistradas();
                        break;
                    case 6:
                        Atividades.AnaliseNumerosInteiros();
                        break;
                    case 7:
                        Atividades.ProdutosEPrecos();
                        break;
                    case 8:
                        Atividades.PesquisaPreferencia();
                        break;
                    case 9:
                        Atividades.ListaTarefas();
                        break;
                    case 10:
                        Atividades.BuscaEstudante();
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                if (opcao != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }
            }
        }
    }
}
