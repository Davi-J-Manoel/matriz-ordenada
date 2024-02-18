using System;

namespace MatrizComOrdenacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] Matriz = new string[3, 4];
            string opc;

            do
            {
                opc = Menu();
                switch (opc)
                {
                    case "1":
                        LerMatriz(Matriz);
                        Console.Clear();
                        break;
                    case "2":
                        ImprimirTodos(Matriz);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "3":
                        ImprimirNomeLinha(Matriz);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        ImprimirColuna(Matriz);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "5":
                        ProcurarNome(Matriz);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "6":
                        OrdenarLinha(Matriz);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida");
                        Console.Write("Pressione uma tecla para prosseguir: ");
                        Console.ReadLine();
                        break;
                }
            } while (opc != "0");
        }

        public static string Menu()
        {
            string opc;
            Console.WriteLine("|---------------------- MENU ----------------------");
            Console.WriteLine("|1 - Ler nomes da matriz");
            Console.WriteLine("|2 - Imprimir nomes de forma completa");
            Console.WriteLine("|3 - Imprimir os nome de uma determinada linha");
            Console.WriteLine("|4 - Imprimir os nomes de uma determinada coluna");
            Console.WriteLine("|5 - Procurar um nome na matriz");
            Console.WriteLine("|6 - Ordenar os nome dentro de cada linha");
            Console.WriteLine("|0 - Sair\n");
            opc = Console.ReadLine();
            Console.Clear();
            return opc;
        }

        public static void LerMatriz(string[,] Matriz)
        {
            for (int l = 0; l < Matriz.GetLength(0); l++)
            {
                for (int c = 0; c < Matriz.GetLength(0); c++)
                {
                    Console.WriteLine($"Informe o nome da posição [{l + 1} , {c + 1}]");
                    string nome = Console.ReadLine();
                    Matriz[l, c] = nome;
                    Console.Clear();
                }
            }
        }

        public static void ImprimirTodos(string[,] Matriz)
        {
            for (int l = 0; l < Matriz.GetLength(0); l++)
            {
                for (int c = 0; c < Matriz.GetLength(0); c++)
                {
                    Console.Write($"[{l + 1} , {c + 1}] = {Matriz[l, c]}\t");
                }
                Console.WriteLine();
            }
        }

        public static void ImprimirNomeLinha(string[,] Matriz)
        {
            Console.Write("Informe a linha que deseja imprimir:  ");
            int linhaImpressao = int.Parse(Console.ReadLine());
            int l, c;
            for (l = linhaImpressao - 1; l < Matriz.GetLength(0);)
            {
                for (c = 0; c < Matriz.GetLength(0); c++)
                {
                    Console.Write($"[{l + 1} , {c + 1}] = {Matriz[l, c]}\t");
                }
                Console.WriteLine();
                break;
            }
        }

        public static void ImprimirColuna(string[,] Matriz)
        {
            Console.Write("Informe a coluna que deseja imprimir:  ");
            int colunaImpressao = int.Parse(Console.ReadLine());
            colunaImpressao -= 1;
            int l, c;
            for (l = 0; l < Matriz.GetLength(0); l++)
            {
                for (c = 0; c < Matriz.GetLength(0); c++)
                {
                    if (colunaImpressao == c)
                    {
                        Console.Write($"[{l + 1} , {c + 1}] = {Matriz[l, c]}\t");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void ProcurarNome(string[,] Matriz)
        {
            Console.Write("Informe o nome que deseja procurar: ");
            string nome = Console.ReadLine();
            bool verdadeiroFalsoNome = false;

            for (int l = 0; l < Matriz.GetLength(0); l++)
            {
                for (int c = 0; c < Matriz.GetLength(0); c++)
                {
                    if (string.Compare(nome, Matriz[l, c], StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        Console.WriteLine($"[{l + 1}, {c + 1} = {Matriz[l, c]}]");
                        verdadeiroFalsoNome = true;
                    }
                    else if (verdadeiroFalsoNome == false)
                    {
                        verdadeiroFalsoNome = false;
                    }
                }
            }
            if (verdadeiroFalsoNome == false)
            {
                Console.WriteLine("Esse nome não está na matriz!");
            }
        }

        public static void OrdenarLinha(string[,] Matriz)
        {
            string auxiliarOrdenador;
            Console.Write("Escolha a linha que deseja ordenar: ");
            int linha = int.Parse(Console.ReadLine());
            int linhaFixa = linha - 1;
 
            for (int l = 0; l < Matriz.GetLength(0); l++)
            {
                for (int c = l + 1; c < Matriz.GetLength(0); c++)
                {
                    if (String.Compare(Matriz[linhaFixa, l], Matriz[linhaFixa, c], StringComparison.Ordinal) > 0)
                    {
                        auxiliarOrdenador = Matriz[linhaFixa, l];
                        Matriz[linhaFixa, l] = Matriz[linhaFixa, c];
                        Matriz[linhaFixa, c] = auxiliarOrdenador;
                    }
                }
            }
        }
    }
}