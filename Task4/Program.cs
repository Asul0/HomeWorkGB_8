// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
using static System.Console;
Clear();



int[,,] array = new int[2, 2, 2];
FillArray(array);
PrintArray(array);



void PrintArray(int[,,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
         WriteLine();
         for (int n = 0; n < arr.GetLength(2); n++)
         {
            Write($"{arr[i, j, n]}({i},{j},{n}) ");
         }
      }
   }
}

void FillArray(int[,,] arr1)
{
   int count = 66;
   for (int i = 0; i < arr1.GetLength(0); i++)
   {
      for (int j = 0; j < arr1.GetLength(1); j++)
      {
         for (int n = 0; n < arr1.GetLength(2); n++)
         {
            arr1[n, i, j] += count;
            count += 3;
         }
      }
   }
}
