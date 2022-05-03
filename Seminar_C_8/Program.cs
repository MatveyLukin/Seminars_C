//Семинар №8
// Задача №1
// Условие: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] CreateRandomMatrix(int row, int column)
{
    int[,] matr = new int[row, column];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    return matr;
}

// int[,] Sweep(int[,] matr)
// {
//     int temp;
//     for (int n = 0; n < matr.GetLength(1); n++)
//     {
//         temp = matr[0, n];
//         matr[0, n] = matr[matr.GetLength(0) - 1, n];
//         matr[matr.GetLength(0) - 1, n] = temp;
//     }
//     return matr;
// }
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j]} ");
        Console.WriteLine();
    }
}
// int[,] matrix = CreateRandomMatrix(4, 3);
// Console.WriteLine();
// PrintMatrix(Sweep(matrix));


// Задача №2
// Условие: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int[,] Sweep1(int[,] matr)
// {
//     int tmp;
//     if (matr.GetLength(0) == matr.GetLength(1))
//     {
//         for (int i = 0; i < matr.GetLength(0); i++)
//         {
//             for (int j = i; j < matr.GetLength(1); j++)
//             {
//                 tmp = matr[i, j];
//                 matr[i, j] = matr[j, i];
//                 matr[j, i] = tmp;
//             }
//         }
//     }
//     else Console.WriteLine("Замена невозможна");
//     return matr;
// }
// int[,] matrix1 = CreateRandomMatrix(3, 3);
// Console.WriteLine();
// PrintMatrix(Sweep1(matrix1));


// Задача №3
// Условие: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[,] CrossDeliting(int[,] matr)
{
    int minI = 0,
         minJ = 0,
         min = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            if (matr[i, j] < min)
            {
                min = matr[i, j];
                minI = i;
                minJ = j;
            }
    }

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        matr[i, minJ] = 0;
    }
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[minI, j] = 0;
    }
    return matr;
}

int[,] matrix2 = CreateRandomMatrix(3, 3);
Console.WriteLine();
PrintMatrix(CrossDeliting(matrix2));