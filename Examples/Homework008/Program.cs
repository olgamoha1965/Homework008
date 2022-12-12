//Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

/*
int [,] Create2dArray (int rows, int columns, int min, int max)
{
    int [,] newArray = new int [rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(min, max + 1);
        }
    }
return newArray;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] StreamlineRows (int [,] array)
{

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if(array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];

                    array[i, k] =  array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
   }
return array;    
}

Console.WriteLine("Input numbers of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Input numbers of columns: ");
int user_columns = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Input min possible value: ");
int user_minValue = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Input max possible value: ");
int user_maxValue = Convert.ToInt32(Console.ReadLine()); 

int [,] newArray = Create2dArray(user_rows, user_columns, user_minValue, user_maxValue);
Show2dArray(newArray);
int [,] streamRows = StreamlineRows(newArray);
Show2dArray(streamRows);
*/

//Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int [,] Create2dArray (int rows, int columns, int min, int max)
{
    int [,] newArray = new int [rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(min, max + 1);
        }
    }
return newArray;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [] SumRows(int [,] array, int rows)
{
    int [] sumRows = new int [rows];
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for(int j = 0; j < array.GetLength(1); j++) 

            summ = summ + array[i, j];
        Console.Write($"{summ} ");
        sumRows[i] = summ;  
     
    }
    Console.WriteLine();
    int min = Array.IndexOf(sumRows, sumRows.Min());
    Console.Write($"Min sum of array elements in row {min}. ");
   
return sumRows;
}

Console.WriteLine("Input numbers of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Input numbers of columns: ");
int user_columns = Convert.ToInt32(Console.ReadLine()); 

if(user_rows == user_columns)
    Console.WriteLine("Input correct numbers of rows and columns!");

Console.WriteLine("Input min possible value: ");
int user_minValue = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Input max possible value: ");
int user_maxValue = Convert.ToInt32(Console.ReadLine()); 

int [,] newArray = Create2dArray(user_rows, user_columns, user_minValue, user_maxValue);
Show2dArray(newArray);
int [] streamRows = SumRows(newArray, user_rows);
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

/*
int [,] Matrix4x4(int rows, int columns)
{

    int [,] newMatrix = new int[rows, columns];
    
    int i = 0;
    int j = 0;
   
    while(i < rows && j < columns)
    {

        int temp = 1;
        for(j = 0; j < columns; j++)
        {
            newMatrix[i, j] = temp;
            temp++;
        }
    
        j = columns - 1; 
        temp = 5;
        for(i = 1; i < rows; i++)
        {
            newMatrix[i, j] = temp;
            temp++;
        }
    
        i = rows - 1;
        temp = 8;
        for(j = columns - 2; j >= 0; j--)
        {
            newMatrix[i, j] = temp;
            temp++;
        }
    
        j = 0;
        temp = 11;
        for(i = rows - 2; i >= 1; i--)
        {
            newMatrix[i, j] = temp;
            temp++;
        }
    
        i = 1;
        temp = 13;
        for(j = 1; j <= columns - 2; j++)
        {
            newMatrix[i, j] = temp;
            temp++;
        }
    
        i = 2;
        temp = 15;
        for(j = columns - 2; j >= 1; j--)
        {
            newMatrix[i, j] = temp;
            temp++;
        }
        i++;
        j++;
        rows--;
        columns--;
    }
    return newMatrix;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] newMatrix4x4 = Matrix4x4(4, 4);
Console.WriteLine("Spiral array: ");
Show2dArray(newMatrix4x4);
*/


//Задача 58(дополнительно). Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

/*
int [,] Create2dArray (int rows, int columns)
{
    int [,] newArray = new int [rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(1, 10);
        }
    }
return newArray;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] MatrixPro(int [,] array1, int [,] array2, int rows, int columns)
{
    int [,] newArray = new int [rows, columns];
    for(int i = 0; i < newArray.GetLength(0); i++)
    {
        for(int j = 0; j < newArray.GetLength(1); j++)
        {
            int result = 0;
            for(int k = 0; k < array1.GetLength(1); k++)
            {

            result += array1[i, k] * array2[k, j];
            }
            
            newArray[i, j] = result;
        
        }
    }
return newArray; 
}

Console.WriteLine("Number of rows in the first matrix must match number of columns in the second matrix!");
Console.WriteLine("Input numbers of rows for arrays: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numbers of columns for arrays: "); 
int user_columns = Convert.ToInt32(Console.ReadLine()); 

int [,] newArray1 = Create2dArray(user_rows, user_columns);
Show2dArray(newArray1);
int [,] newArray2 = Create2dArray(user_rows, user_columns);
Show2dArray(newArray2);
int [,] res = MatrixPro(newArray1, newArray2, user_rows, user_columns);
Console.WriteLine("Product of two matrices: ");
Show2dArray(res); 
*/


//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

/*
int [,,] Array3d(int card, int row, int column)
{
    int[,,] array3d = new int[card, row, column];

    for(int i = 0; i < card; i++)
    {
        for(int j = 0; j < row; j++)
        {
            for(int k = 0; k < column; k++)
            {
               array3d[i, j, k] = new Random().Next(10, 100); 
            }
        }
    }
return array3d;
}

void Show3dArray(int [,,] array3d)
{
    for(int i = 0; i < array3d.GetLength(0); i++)
    {
        for(int j = 0; j < array3d.GetLength(1); j++)
        {
            for(int k = 0; k < array3d.GetLength(2); k++)
            {
                Console.Write($"{array3d[i,j,k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }    
}

Console.WriteLine("Input size of the 3D array.");
Console.WriteLine("Input first size: ");
int user_card = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second size: ");
int user_row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third size: "); 
int user_column = Convert.ToInt32(Console.ReadLine());

int [,,] newArray3d = Array3d(user_card, user_row, user_column);
Show3dArray(newArray3d);
*/

