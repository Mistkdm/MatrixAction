using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Matrix
{
    internal class Matrix
    {
        int N { get; set; }
        int M { get; set; }

        double[,] FirstMatrix { get; set; }
        public Matrix(int n, int m, in DataGridView dg)
        {
            N = n;
            M = m;
            FirstMatrix = new double[N, M];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    FirstMatrix[i, j] = double.Parse(dg.Rows[i].Cells[j].Value.ToString());
                }
        }

        public void Addiction(Matrix m, DataGridView Result)
        {
            FillMatrix(Result, FirstMatrix.GetLength(0), FirstMatrix.GetLength(1));
            if (FirstMatrix.GetLength(0) == m.FirstMatrix.GetLength(0) && FirstMatrix.GetLength(1) == m.FirstMatrix.GetLength(1))
            {
                for (int i = 0; i < N; i++)
                    for (int j = 0; j < M; j++)
                    {
                        Result.Rows[i].Cells[j].Value = FirstMatrix[i, j] + m.FirstMatrix[i, j];
                    }
            }
            else
            {
                MessageBox.Show("Введите корректное значение размера матриц");
            }
        }
        public void Substraction(Matrix m, DataGridView Result)
        {
            FillMatrix(Result, FirstMatrix.GetLength(0), FirstMatrix.GetLength(1));
            if (FirstMatrix.GetLength(0) == m.FirstMatrix.GetLength(0) && FirstMatrix.GetLength(1) == m.FirstMatrix.GetLength(1))
            {
                for (int i = 0; i < N; i++)
                    for (int j = 0; j < M; j++)
                    {
                        Result.Rows[i].Cells[j].Value = FirstMatrix[i, j] - m.FirstMatrix[i, j];
                    }
            }
            else
            {
                MessageBox.Show("Введите корректное значение размера матриц");
            }
        }
        public void Multiplication(Matrix m, DataGridView Result)
        {
            if (FirstMatrix.GetLength(0) == m.FirstMatrix.GetLength(1))
            {
                FillMatrix(Result, FirstMatrix.GetLength(0), m.FirstMatrix.GetLength(1));
                for (int i = 0; i < N; i++)
                    for (int j = 0; j < m.FirstMatrix.GetLength(1); j++)
                    {
                        double temp = 0;
                        for(int k = 0; k< this.M; k++)
                        {
                            temp += FirstMatrix[i, k] * m.FirstMatrix[k, j];
                        }
                        Result.Rows[i].Cells[j].Value = temp;
                    }
            }
            else
            {
                MessageBox.Show("Введите корректное значение размера матриц");
            }
        }
        internal static void FillMatrix(DataGridView e, int i, int j)
        {
            e.RowCount = i;
            e.ColumnCount = j;
        }
    }
}
