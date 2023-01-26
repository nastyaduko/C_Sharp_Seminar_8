//**Задача 53:** Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и последнюю строку массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//8 4 2 4
//5 9 2 3
//1 4 7 2

// int[,] array = GetArray(3,4,0,10);
// PrintArray(array);

// System.Console.WriteLine();


// System.Console.WriteLine(check);
// // Change(array);
// // PrintArray(array);
// // ------------------
// int [,] GetArray (int m, int n, int minValue, int maxValue)
// {
//     int[,] array2 = new int[m, n];
//     for(int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array2[i,j] = new Random().Next(minValue,maxValue+1);
//         }
//     }
//     return array2;
// }

// void PrintArray(int[,] collection)
// {
//     for (int i = 0; i < collection.GetLength(0); i++)
//     {
//         for (int j = 0; j < collection.GetLength(1); j++)
//         { Console.Write($"{collection[i, j]} "); }
//         Console.WriteLine();
//     }
// }


// void Change(int[,] array)
// {
//     for(int i =0; i <array.GetLength(1);i++)
//        {

//         int temp = array[0,i];
//         array[0,i] = array[array.GetLength(0)-1,i];
//         array[array.GetLength(0)-1,i] = temp;
//        }
// }


// // Задача 55:** Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// // В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // В итоге получается вот такой массив:
// // 1 5 8 5
// // 4 9 4 2
// // 7 2 2 6
// // 2 3 4 7


// int[,] array = GetArray(4,4,0,10);
// PrintArray(array);

// System.Console.WriteLine();

// bool check = Check(array);
// System.Console.WriteLine(check);

// int[,] changedArray = Change(array);

// if(check) PrintArray(changedArray);
// else System.Console.WriteLine("Это невозможно");

// // Change(array);
// // PrintArray(array);
// // ------------------

// bool Check(int[,] array)
// {
//     return array.GetLength(0) == array.GetLength(1);
// }

// int [,] GetArray (int m, int n, int minValue, int maxValue)
// {
//     int[,] array2 = new int[m, n];
//     for(int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array2[i,j] = new Random().Next(minValue,maxValue+1);
//         }
//     }
//     return array2;
// }

// void PrintArray(int[,] collection)
// {
//     for (int i = 0; i < collection.GetLength(0); i++)
//     {
//         for (int j = 0; j < collection.GetLength(1); j++)
//         { Console.Write($"{collection[i, j]} "); }
//         Console.WriteLine();
//     }
// }

// int[,] Change(int[,] array)
// {
//     int[,] changedArray = new int[array.GetLength(0),array.GetLength(1)];
//     for(int i = 0; i <array.GetLength(0); i++)
//     {
//         for(int j = 0; j <array.GetLength(1); j++)
//         {
//             changedArray[i,j] = array[j,i];
//         }
//     }
// return changedArray;
// }

// Задача 59: Из двумерного массива целых чисел удалить строку и столбец, 
//на пересечении которых расположен наименьший элемент.
// if (i == indexes[0]) continue;

int[,] array = GetArray(4,4,0,10);
PrintArray(array);
System.Console.WriteLine();

PrintArray(ChangedArray(array, minIndex(array)));


int [,] GetArray (int m, int n, int minValue, int maxValue)
{
    int[,] array2 = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array2[i,j] = new Random().Next(minValue,maxValue+1);
        }
    }
    return array2;
}

void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        { Console.Write($"{collection[i, j]} "); }
        Console.WriteLine();
    }
}

int[] minIndex (int[,] array)
{
    int min = array[0,0];
    int[] index = new int[] {0,0};
    for(int i=0; i< array.GetLength(0); i++)
        {
            for(int j=0; j< array.GetLength(1); j++)
            {
                if(array[i,j]<min)
                {
                    min = array[i,j];
                    index[0] = i;
                    index[1] = j;
                }
            }
        }
        return index;
}

int[,] ChangedArray (int[,] array, int[] index)
{
    int[,] newArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    int k = 0;
    int l = 0;
    for(int i=0; i< array.GetLength(0); i++)
        {
            if(i == index[0]) continue;
            
            for(int j=0; j< array.GetLength(1); j++)
            {
                if(j == index[1]) continue;
                {newArray[k,l] = array[i,j];
                l++;}
            }
            l=0; 
            k++;
         
        }
        return newArray;
}