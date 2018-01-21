using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_16_OOTPIS
{
    class Matrix : BaseMatrix
    {
        public Matrix() : base() { }
        public Matrix(int size) : base(size) { }

        public void ReplaceDiagonals()
        {
            for (int i = 0; i < Size; i++)
            {
                if (i == Size - i - 1) {
                    //Если мы находимся в середине, то переходим на следующую итерацию
                    continue;
                }
                //Меняем местами главную и побочную диагонали
                matrix[i, i] += matrix[i, Size - i - 1];
                matrix[i, Size - i - 1] = matrix[i, i] - matrix[i, Size - i - 1];
                matrix[i, i] -= matrix[i, Size - i - 1];
            }
        }
    }
}
