using System.Security.Cryptography;

class MatrixMultiplier
{
    public static Matrix ParallelMultiplier(Matrix a, Matrix b, int threads)
    {
        //Brak sprawdzania czy można mnożyc bo mamay macierze kwadratowe
        int n = a.Rows;
        int m = b.Cols;
        int common = a.Cols;
        Matrix result = new Matrix(n, m);

        ParallelOptions opt = new ParallelOptions() { MaxDegreeOfParallelism = threads };

        Parallel.For(0, n, opt, i =>
        {
            for (int j = 0; j < m; j++)
            {
                int sum = 0;
                for (int k = 0; k < common; k++)
                {
                    sum += a.matrix[i, k] * b.matrix[k, j];
                }
                result.matrix[i, j] = sum;

            }
        });
        return result;
    }

    public static Matrix ThreadMultiplier(Matrix a, Matrix b, int threads)
    {
        int n = a.Rows;
        int m = b.Cols;
        int common = a.Cols;
        Matrix result = new Matrix(n, m);

        Thread[] workers = new Thread[threads];
        int rowsPerThread = n / threads;

        for(int i = 0; i < threads; i++)
        {
            int startRow = i * rowsPerThread;
            int endRow = 0;
            if(i == threads - 1)
            {
                endRow = n;
            }
            else
            {
                endRow = startRow + rowsPerThread;
            }
            workers[i] = new Thread(() =>
            {
                for (int row = startRow; row < endRow; row++)
                {
                    for (int col = 0; col < m; col++)
                    {
                        int sum = 0;
                        for (int k = 0; k < common; k++)
                        {
                            sum += a.matrix[row, k] * b.matrix[k, col];
                        }
                        result.matrix[row, col] = sum;
                    }
                }
            });
            workers[i].Start();

        }

        foreach (var thread in workers)
            thread.Join();

        return result;

    }
}

