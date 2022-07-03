/* Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого 
элемента или же указание, что такого элемента нет.
*/

Console.WriteLine("Задача 050");
Random rand = new Random();
double[,] array = new double[3,6];
int row;
int column;

FillArray(array);
PrintArray(array);

Console.WriteLine("Введите номер строки: ");
row = Convert.ToInt32(Console.ReadLine());   

Console.WriteLine("Введите номер столбца: ");
column = Convert.ToInt32(Console.ReadLine());   

if(row <= array.GetLength(0) && column <= array.GetLength(1))
    {   
        Console.WriteLine($"Элемент: {array[row-1,column-1]}");
    }

else
    {
    Console.WriteLine("Элемент не найден");
    }
void FillArray(double[,] currentArray)
    {
        for (int i = 0; i < currentArray.GetLength(0); i++)
            {
            for (int j = 0; j < currentArray.GetLength(1); j++)
            {
            currentArray[i,j] = Math.Round(rand.NextDouble()*10,1);
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
            Console.Write(currentArray[i,j] +  "\t");
            }
             Console.WriteLine();
            }
    }

    
