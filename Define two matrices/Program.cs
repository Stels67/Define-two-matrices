using System;

int[,] matrix = new int[3, 3];
int[,] secondMatrix = new int[3, 3];
Random rndm = new Random();
InitArray(matrix);
PrintArray(matrix);
Console.WriteLine();
InitArray(secondMatrix);
PrintArray(secondMatrix);
int[,] resultMatrix = new int[3, 3];
MatrixMultiplication(matrix, secondMatrix, resultMatrix);
Console.WriteLine();
PrintArray(resultMatrix);




void InitArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            array[rows, columns] = rndm.Next(1, 10);
        }
    }
}

void MatrixMultiplication(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
    if (firstArray.GetLength(0) != secondArray.GetLength(0) || firstArray.GetLength(1) != secondArray.GetLength(1))
        Console.WriteLine("Матрицы разного размера");
    else
        for (int rows = 0; rows < firstArray.GetLength(0); rows++)
        {
            for (int columns = 0; columns < firstArray.GetLength(1); columns++)
            {
                resultArray[rows, columns] = firstArray[rows, columns] * secondArray[rows, columns];
            }
        }
}

void PrintArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            Console.Write($"{array[rows, columns],-5}");
        }
        Console.WriteLine();
    }
}