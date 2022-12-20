// int[,] CreateRandomArray()
// {
//     Console.WriteLine("input a number of rows ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("input a number of colums ");
//     int colums = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("input a min possible value ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("input a max possible value ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
    
//     int[,] array = new int[rows, colums];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < colums; j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }
// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0;j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] myArray = CreateRandomArray();
// Show2dArray(myArray);

/*// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.

int[,] CreateArray(int rows, int colums)
{
    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            array[i,j] = i+j;
        }
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0;j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

    Console.WriteLine("input a number of rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input a number of colums ");
    int colums = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateArray(rows, colums);
Show2dArray(myArray);
*/

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// int[,] CreateArray(int rows, int colums, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, colums];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < colums; j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0;j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void QuadSwitch(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i += 2)
//         for (int j = 0; j < array.GetLength(1); j+=2)
//             array[i,j] *= array[i,j];
// }

// Console.WriteLine("input a number of rows ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input a number of colums ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input a min possible value ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input a max possible value ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateArray(rows, colums, minValue, maxValue);
// Show2dArray(myArray);
// QuadSwitch(myArray);
// Show2dArray(myArray);

// Сумма элементов по главной диоганали двумерного массива
int[,] CreateArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0;j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int Dioganal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum += array[i,i];
    return sum;
}
Console.WriteLine("input a number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input a number of colums ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input a min possible value ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input a max possible value ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateArray(rows, colums, minValue, maxValue);
Show2dArray(myArray);
int sum = Dioganal(myArray);
Console.WriteLine($"sum is {sum}");