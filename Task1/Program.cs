// Задача 54: Задайте двумерный массив. Напишите программу, которая 
//упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


using static System.Console;
Clear();
Write("Введите размер матрицы через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] rename = Array.ConvertAll(parameters, Convert.ToInt32);

int[,] array = GetMatrixArray(rename[0], rename[1]);

PrintMatrixArray(array);
SelectionSort(array);
WriteLine("--В итоге получается вот такой массив:--");
ModifiedArray(array);

int[,] GetMatrixArray(int rows, int columns)
{
   int[,] resultArray = new int[rows, columns];
   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < columns; j++)
      {
         resultArray[i, j] = (new Random().Next(1, 15));
      }
   }
   return resultArray;
}


void SelectionSort(int[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
         for (int n = 0; n < arr.GetLength(1) - 1; n++)
         {
            if (arr[i, n] < arr[i, n + 1])
            {
               int temp = array[i, n + 1];
               arr[i, n + 1] = arr[i, n];
               arr[i, n] = temp;
            }
         }
      }
   }
}


void PrintMatrixArray(int[,] inArray)
{
   for (int i = 0; i < inArray.GetLength(0); i++)
   {
      for (int j = 0; j < inArray.GetLength(1); j++)
      {
         Write($"{inArray[i, j],4}");
      }
      WriteLine();
   }
}


void ModifiedArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write($"{array[i, j],4}");
      }
      Console.WriteLine();
   }
}
