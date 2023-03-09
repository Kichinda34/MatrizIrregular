using System.Drawing;
using System.Runtime.Intrinsics.X86;

internal class Program
{
    private static void Main(string[] args)
    {
        double[,] matriz = new double[5, 3];

        for (int l = 0; l < 5; l++)
        {
            for (int c = 0; c < 3; c++)
            {
                Random n = new Random();
                double b = n.NextDouble() * 100;

                if (c == 0 || c == 1)
                {
                    matriz[l, c] = b;
                }
                if (c == 2)
                {
                    matriz[l, c] = (matriz[l, 0] + matriz[l, 1]) / 2;
                }
                Console.Write(matriz[l,c] + " | \n");
            }
        }
    }
}




