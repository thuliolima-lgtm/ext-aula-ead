using System;
using MinhaBiblioteca;

class Program
{
    static int contarRaiosMesmoLocal(int[,] matriz)
    {
        int cont = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] > 1)
                {
                    cont++;
                }
            }
        }

        return cont;
    }

    static void Main()
    {
        int x, y, quantidadeRaios;
        int linhas, cols;

        Console.WriteLine("Quantidade de linhas e colunas da área:");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());

        int[,] mapa = new int[linhas, cols];

        Console.Write("Quantos raios foram anotados:");
        quantidadeRaios = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidadeRaios; i++)
        {
            Console.Write("Coordenadas que o raio caiu: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            mapa[x, y]++;
        }

        if (contarRaiosMesmoLocal(mapa) > 0)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}