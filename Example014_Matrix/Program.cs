﻿// string[,] table = new string[2,5];
// table[1,2] = "слово";

// for (int row = 0; row < 2; row++)
// {
//     for (int colums = 0; colums <5; colums++)
//     {
//         Console.WriteLine($"-{table[row, colums]}-");
//     }
// }

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
        Console.Write($"{matr[i, j]} ");
      }
    Console.WriteLine();   
    } 
}    

void FillArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
     {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
        matr[i,j] = new Random().Next(1,10); // [1,10)
       }
     }  
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);