
using System;
using System.Data;

class Matrix
{
    public int[,] matrix { get; private set; }
    public int Rows;
    public int Cols;

    public Matrix(int rows, int columns, bool doRandom = false)
    {
        matrix = new int[rows, columns];
        Rows = rows;
        Cols = columns;

        if(doRandom)
            Randomize();

    }

    public void Randomize()
    {
        Random random = new Random();
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                matrix[i, j] = random.Next(1, 10);
            }
        }
    }

    public void PrintMatrix()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                Console.Write($"{matrix[i, j],4}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

     
}