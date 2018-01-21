using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_16_OOTPIS
{
    class BaseMatrix
    {
        protected int[,] matrix;
        public int Size { get; private set; }
        public BaseMatrix(int size)
        {
            if (size <= 0)
            {
                throw new Exception("Размерность матрицы должна быть больше 0!");
            }
            this.Size = size;
            Random random = new Random();
            matrix = new int[size, size];
            //Заполняем матрицу рандомными значениями
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    matrix[i, j] = random.Next(-Size * 2, Size * 2);
                }
            }
        }

        public BaseMatrix() : this(5) { }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    result += matrix[i, j] + "\t";
                }
                result += "\n";
            }
            return result;
        }
    }
}
