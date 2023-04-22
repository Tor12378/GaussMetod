using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauss
{
    public class Generate
    {
        public static double[][] GenerateRandomMatrix(int size)
        {
            double[][] matrix = new double[size][];
            for (int i = 0; i < size; i++)
            {
                matrix[i] = new double[size];
                for (int j = 0; j < size; j++)
                {
                    matrix[i][j] = rand.NextDouble() * 2 - 1;
                }
            }
            return matrix;
        }

        public static double[] GenerateRandomVector(int size)
        {
            double[] vector = new double[size];
            for (int i = 0; i < size; i++)
            {
                vector[i] = rand.NextDouble() * 2 - 1;
            }
            return vector;
        }

        static Random rand = new Random();
    }
}

