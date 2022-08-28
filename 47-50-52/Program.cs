using System;

namespace _47_50_52
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите номер задачи 47, 50, 52: ");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            switch (taskNumber)
            {
                case 47:
                    TaskFourtyseven();
                    break;
                case 50:
                    TaskFifty();
                    break;
                case 52:
                    TaskFiftytwo();
                    break;
                default:
                    Console.WriteLine("Такой задачи не существует");
                    break;
            }
        }

        #region Задача 47
        /*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
        m = 3, n = 4.
        0,5 7 -2 -0,2
        1 -3,3 8 -9,9
        8 7,8 -7,1 9*/

        static void TaskFourtyseven()
        {
            Console.Write("Введите количество строк и столбцов через Enter ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int columns = Convert.ToInt32(Console.ReadLine());
            double[,] matrix = new double[rows, columns];

            Random rand = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Math.Round(rand.NextDouble()*10, 2);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Задача 50
        /*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
        и возвращает значение этого элемента или же указание, что такого элемента нет.
        Например, задан массив:
        1 4 7 2
        5 9 2 3
        8 4 2 4
        1 7 -> такого числа в массиве нет*/

        static void TaskFifty()
        {

        }
        #endregion


        #region Задача 52
        /*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
        Например, задан массив:
        1 4 7 2
        5 9 2 3
        8 4 2 4
        Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

        static void TaskFiftytwo()
        {

        }
        #endregion
    }
}
