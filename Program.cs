using System.Diagnostics;

namespace Gauss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = { 100, 1000,10000  };
            int[] threadCounts = { 1, 2, 4, 8, 16 };
            
            foreach (int size in matrixSizes)
            {
                
                Console.WriteLine("size: " + size);
                double[][] matrix = Generate.GenerateRandomMatrix(size);
                double[] vector = Generate.GenerateRandomVector(size);

                foreach (int threadCount in threadCounts)
                {
                    Console.WriteLine("Thread count: " + threadCount);

                    
                    Stopwatch stopwatch = Stopwatch.StartNew();
                    GaussThread.SolveGaussThread(matrix, vector, threadCount);
                    stopwatch.Stop();
                    Console.WriteLine("Thread  time: " + stopwatch.Elapsed.TotalMilliseconds );

                    
                    stopwatch = Stopwatch.StartNew();
                    GaussTask.SolveGaussTask(matrix, vector, threadCount);
                    stopwatch.Stop();
                    Console.WriteLine("Task  time: " + stopwatch.Elapsed.TotalMilliseconds );

                    
                    stopwatch = Stopwatch.StartNew();
                    GaussParallelFor.SolveGaussParallelFor(matrix, vector, threadCount);
                    stopwatch.Stop();
                    Console.WriteLine("Parallel.For  time: " + stopwatch.Elapsed.TotalMilliseconds);
                }
            }
        }
    }
}