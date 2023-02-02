// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
using static System.Console;
Clear();

Write("Введите размер первой матрицы через пробел: ");
string[] parametrs = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] num = Array.ConvertAll(parametrs, Convert.ToInt32);
int[,] array = GetMatrix(num[0], num[1]);
PrintArray(array);
WriteLine();

Write("Введите размер второй матрицы через пробел: ");
string[] parametrs2 = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] num2 = Array.ConvertAll(parametrs2, Convert.ToInt32);
int[,] array2 = GetMatrix2(num2[0], num2[1]);
PrintArray2(array2);

int[,] resultMatrix = new int[num[0], num2[1]];

ResultMatrix(array, array2, resultMatrix);
WriteLine($"Произведение первой и второй матрицы:");
PrintArray3(resultMatrix);

void ResultMatrix(int[,] array, int[,] array2, int[,] resMatrix)
{
   for (int i = 0; i < resMatrix.GetLength(0); i++)
   {
      for (int j = 0; j < resMatrix.GetLength(1); j++)
      {
         int sum = 0;
         for (int k = 0; k < array.GetLength(1); k++)
         {
            sum += array[i, k] * array2[k, j];
         }
         resMatrix[i, j] = sum;
      }
   }
}


int[,] GetMatrix(int rows, int colums)
{
   int[,] resultArray = new int[rows, colums];
   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < colums; j++)
      {
         resultArray[i, j] = new Random().Next(1, 15);
      }
   }
   return resultArray;
}

int[,] GetMatrix2(int rows2, int colums2)
{
   int[,] resultArray2 = new int[rows2, colums2];
   for (int i = 0; i < rows2; i++)
   {
      for (int j = 0; j < colums2; j++)
      {
         resultArray2[i, j] = new Random().Next(1, 15);
      }
   }
   return resultArray2;
}

void PrintArray(int[,] inArray)
{
   for (int i = 0; i < inArray.GetLength(0); i++)
   {
      for (int j = 0; j < inArray.GetLength(1); j++)
      {
         Write($"{inArray[i, j],5}");
      }
      WriteLine();
   }
}

void PrintArray2(int[,] inArray2)
{
   for (int i = 0; i < inArray2.GetLength(0); i++)
   {
      for (int j = 0; j < inArray2.GetLength(1); j++)
      {
         Write($"{inArray2[i, j],5}");
      }
      WriteLine();
   }
}

void PrintArray3(int[,] inArray3)
{
   for (int i = 0; i < inArray3.GetLength(0); i++)
   {
      for (int j = 0; j < inArray3.GetLength(1); j++)
      {
         Write($"{inArray3[i, j],5}");
      }
      WriteLine();
   }
}
