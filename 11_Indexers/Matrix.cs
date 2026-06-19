using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Indexers
{
    class Matrix
    {
        int[,] matrix;
        public Matrix(int r = 2, int c = 2)
        {
            matrix = new int[r, c]; //0
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder(100);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    str.Append($"{matrix[i, j],7}");
                }
                str.AppendLine();
            }
            return str.ToString();
        }
        public int this[int r, int c]
        {
            get => matrix[r, c];
            set => matrix[r, c] = value;
        }

    }
}
