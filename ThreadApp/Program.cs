using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

internal class Program
{
    static void Main(string[] args)
    {
        int size = 500;
        int thread = 10;

        Matrix A = new Matrix(size, size, true);
        Matrix B = new Matrix(size, size, true);

        Console.WriteLine($"Matrix A [{size} x {size}]: ");
        //A.PrintMatrix();

        Console.WriteLine($"Matrix B [{size} x {size}]: ");
        //B.PrintMatrix();

        Console.WriteLine("--------------------Zadanie 1--------------------\n");

       for (int threadCount = 1; threadCount <= 8; threadCount++)
        {
            Matrix parallelMatrix = null;
            long parallelTime = MeasureTime(() =>
            {
                parallelMatrix = MatrixMultiplier.ThreadMultiplier(A, B, threadCount);
            });
            Console.WriteLine($"Czas mnożenia równoległego dla {threadCount} wątku(ów): {parallelTime} ms");
        }


        Console.WriteLine("\n--------------------Zadanie 2--------------------\n");

        for (int threadCount = 1; threadCount <= 8; threadCount++)
        {
            Matrix threadMatrix = null;
            long threadTime = MeasureTime(() =>
            {
                threadMatrix = MatrixMultiplier.ThreadMultiplier(A, B, threadCount);
            });
            Console.WriteLine($"Czas mnożenia (niskopoziomowego) dla {threadCount} wątku(ów): {threadTime} ms");
        }

        /*
        Console.WriteLine("\nMultiplier matrix: ");
        for (int i = 0; i < parallelMatrix.Rows; i++)
        {
            for (int j = 0; j < parallelMatrix.Cols; j++)
            {
                Console.Write($"{parallelMatrix.matrix[i,j],7}");
            }
            Console.WriteLine();
        }
        */
        static long MeasureTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            action();

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

    }

}
