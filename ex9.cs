using System;
using MinhaBiblioteca;

class Program
{
    static int somarForcaRegiao(int[,] matriz, int linha)
    {
        int somaRegiao = 0;

        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            somaRegiao = somaRegiao + matriz[linha, j];
        }

        return somaRegiao;
    }

    static void Main()
    {
        int linhas, cols;

        Console.WriteLine("Quantidade de linhas e colunas da área:");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());

        int[,] matrizTropas = new int[linhas, cols];

        Matriz.gerarMatriz(matrizTropas);

        Console.WriteLine("Matriz das Tropas:");

        for (int i = 0; i < linhas; i++)
        {
            Console.Write("Região " + (i + 1) + ": ");

            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrizTropas[i, j] + " ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Força Total das Regiões:");

        for (int i = 0; i < linhas; i++)
        {
            int forca = somarForcaRegiao(matrizTropas, i);
            Console.WriteLine("Região " + (i + 1) + ": " + forca + " tropas");
        }
    }
}