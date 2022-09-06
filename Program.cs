// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int sizeX = 2;
int sizeY = 2;
int sizeZ = 2;
int minValue = 10;
int maxValue = 99;
Console.Clear();

int[,,] resultarray3D = FillArray3D(sizeX, sizeY, sizeZ, minValue, maxValue);
PrintArray3D(resultarray3D);

int[,,] FillArray3D(int x, int y, int z, int minValue = 10, int maxValue = 99)
{
    int[,,] array = new int[x, y, z];
    Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                while (array[i, j, h] == 0)
                {
                    int number = rand.Next(minValue, maxValue + 1);

                    if (doubleNumberInArray(array, number) == false)
                    {
                        array[i, j, h] = number;
                    }
                }

            }
        }
    }
    return array;
}

bool doubleNumberInArray(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                if (array[i, j, h] == number) return true;
            }
        }
    }

    return false;
}

void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                Console.Write(array[i, j, h]);
                Console.Write("({0},{1},{2})\t", i, j, h);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}
