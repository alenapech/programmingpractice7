/* Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами, 
округлёнными до одного знака.
*/

Console.WriteLine("Задача 047");
Random rand = new Random();
int rows = rand.Next(2,10);
int columns = rand.Next(2,10);

double[,] array = new double[rows, columns];
Console.WriteLine("Количество строк в двумерном массиве: " + array.GetLength(0));
Console.WriteLine("Количество столбцов в двумерном массиве: " + array.GetLength(1));
FillArray(array);
PrintArray(array);

        

void FillArray(double[,] currentArray)
    {
        for (int i = 0; i < currentArray.GetLength(0); i++)
            {
            for (int j = 0; j < currentArray.GetLength(1); j++)
            {
            currentArray[i,j] = rand.NextDouble()*10;
            }
        
        }
    }

void PrintArray(double[,] currentArray)
    {
        Console.WriteLine();
        for (int i = 0; i < currentArray.GetLength(0); i++)
            {
            for (int j = 0; j < currentArray.GetLength(1); j++)
            {
            Console.Write(Math.Round(currentArray[i,j], 1) +  "\t");
            }
             Console.WriteLine();
            }
    }

    
