using System.Drawing;
using System.Runtime.Intrinsics.X86;

internal class Program
{
    private static void Main(string[] args)
    {
        double[,] matriz = new double[5, 3];

        Console.WriteLine("Calculando...");
        Console.WriteLine("Os valores da Matriz são: ");
        for (int l = 0; l < 5; l++)
        {
            for (int c = 0; c < 3; c++)
            {
                Random n = new Random();
                double b = (double) n.Next(1000)/100;

                if (c == 0 || c == 1)
                {
                    matriz[l, c] = b;
                }
                if (c == 2)
                {
                    matriz[l, c] = (matriz[l, 0] + matriz[l, 1]) / 2;
                }
                Console.Write("\tmatriz[" + l + "][" + c + "]" + matriz[l, c].ToString("f2"));
            }
            Console.WriteLine();

        }


        /*otimizado
           for (int c = 0; c < matriz.GetLength(1)-1; c++)
           {
               for (int l = 0; l < matriz.GetLength(0); l++)
               {
                   matriz[l,c] = (double) b.Next(1000)/100;
               }
           }

           //imprimindo a matriz

               for (int l = 0; l < matriz.GetLength(0); l++)
               {
                   for (int c = 0; c < matriz.GetLength(1)-1; c++)
                   {
                       Console.Write("matriz[" + l + "][" + c + "]" + matriz[l,c]);
                   }
               }

           //calculo 3º coluna

           Console.WriteLine("Calculando...");
           for (int l = 0; l < matriz.GetLength(0); l++)
           {
               matriz[l,2] = (matriz[l,0] + matriz[l,1]);
           }
           */
    }
}




