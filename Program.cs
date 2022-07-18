internal class Program
{
    private static void Main(string[] args)
    {
        void FillMatrixDouble(double[,] matrix, double max, double min)
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = rnd.NextDouble() * (max + min) - min;
                    //Console.Write("{0:0.0}",matrix[i,j]);
                    //Console.Write("\t");
                }
                //Console.WriteLine();
            }
        }

        void FillMatrixInt(int[,] matrix, int max, int min)
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = rnd.Next(min,max);
                    //Console.Write("{0:0.0}",matrix[i,j]);
                    //Console.Write("\t");
                }
                //Console.WriteLine();
            }
        }

        void PrintMatrixDouble(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0:0.0}",matrix[i,j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }

        void PrintMatrixInt(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }

        void Zadacha1()
        {
            Console.WriteLine("Задача 1. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами, округлёнными до одного знака.");
            Console.WriteLine("Введи количество строк");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи количество столбцов");
            int colums = Convert.ToInt32(Console.ReadLine());
            var maxRandom = 20.79;
            var minRandom = -6.79;
            double[,] myMatrix = new double[row,colums];

            FillMatrixDouble(myMatrix, maxRandom, minRandom);
            Console.WriteLine("печать массива");
            PrintMatrixDouble(myMatrix);
        }

        void Zadacha2()
        {
            Console.WriteLine("Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
            Console.WriteLine("Введи количество строк");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи количество столбцов");
            int colums = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи строку");
            int searchRow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи стлбец");
            int searchColums = Convert.ToInt32(Console.ReadLine());
            int maxRandom = 20;
            int minRandom = 1;
            int[,] myMatrix = new int[row,colums];
            FillMatrixInt(myMatrix, maxRandom, minRandom);
            Console.WriteLine("печать массива");
            PrintMatrixInt(myMatrix);
            if ((searchRow <= row)&&(searchColums<= colums))
            {
                Console.WriteLine($"Число в строке {searchRow} в столбце {searchColums}: {myMatrix[searchRow,searchColums]}");
            } else Console.WriteLine("Вне диапозона массива");
        }

        void Zadacha3()
        {
            Console.WriteLine("Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
            Console.WriteLine("Введи количество строк");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи количество столбцов");
            int colums = Convert.ToInt32(Console.ReadLine());
            int maxRandom = 20;
            int minRandom = 1;
            double summaruColum = 0;
            int[,] myMatrix = new int[row,colums];
            FillMatrixInt(myMatrix, maxRandom, minRandom);
            Console.WriteLine("печать массива");
            PrintMatrixInt(myMatrix);
            List<double> list = new List<double>();
            for (int j = 0; j < myMatrix.GetLength(1); j++)
            {
              for (int i = 0; i <myMatrix.GetLength(0); i++) 
              {
                summaruColum = summaruColum + Convert.ToDouble(myMatrix[i,j]);
              }
              summaruColum = summaruColum/myMatrix.GetLength(0);
              list.Add(summaruColum);
              summaruColum = 0;
              
            }
            Console.WriteLine("среднее арифметическое элементов в каждом столбце:");
            for (int i = 0; i <list.Count; i++)
            {
                Console.Write("{0:0.0}",list[i]);
                Console.Write("\t");
            }

        }

        void Zadacha4()
        {
            Console.WriteLine("Задача 4. Даны две матрицы, количество строк и столбцов которых может быть 3 или 4, заполнены числами от -9 до 9. Выполните умножение матриц.");
            Console.WriteLine("Введи количество строк");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи количество столбцов");
            int maxRandom = 9;
            int minRandom = -9;
            int[,] matrixFirst = new int[row,row];
            int[,] matrixSecond = new int[row,row];
            int[,] matrixResault = new int[row,row];
            Console.WriteLine("Матрица 1");
            FillMatrixInt(matrixFirst, maxRandom, minRandom);
            PrintMatrixInt(matrixFirst);
            Console.WriteLine("Матрица 2");
            FillMatrixInt(matrixSecond, maxRandom, minRandom);
            PrintMatrixInt(matrixSecond);
            for (int i = 0; i < matrixFirst.GetLength(0); i++)
            {
                for (int j = 0; j < matrixSecond.GetLength(1); j++)
                {
                    for(int k = 0; k < matrixSecond.GetLength(1); k++)
                    matrixResault[i,j] += matrixFirst[i,k] * matrixSecond[k,j];
                }
                
            }
            Console.WriteLine("резултат перемножения матрицы A x B");
            PrintMatrixInt(matrixResault);
            }
        //Zadacha1();
        //Zadacha2();
        //Zadacha3();
        Zadacha4();


    }
}
