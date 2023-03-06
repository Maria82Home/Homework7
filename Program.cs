//Task1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double[,] CreateRandom2DArray()
{
  Console.Write("Input amount of rows: ");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input amount of columns: ");
  int columns = Convert.ToInt32(Console.ReadLine());

  double[,] array = new double[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {  
      //Random temp = new Random();
      //array[i, j] = Math.Round(temp.NextDouble(),2);
      array[i,j]=(double)(new Random().Next(0,100))/10;
    }
  return array;
};

void Show2DArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i, j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

/*
double[,] newArray = CreateRandom2DArray();
Show2DArray(newArray);
*/

//Task2. Напишите программу, которая на вход 
//принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
int[,] CreateRandom2DArray()
{
  Console.Write("Input amount of rows: ");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input amount of columns: ");
  int columns = Convert.ToInt32(Console.ReadLine());

  int[,] array = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {  
      //Random temp = new Random();
      //array[i, j] = Math.Round(temp.NextDouble(),2);
      array[i,j]=(int)(new Random().Next(0,100))/10;
    }
  return array;
};

void Show2DArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i, j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

void ElementPosition(int[,] array, int rowofelement, int columnofelement) 
{
  if(rowofelement>=array.GetLength(0)||columnofelement>=array.GetLength(1))
  Console.Write("There is no such an element");
  else Console.WriteLine(array[rowofelement,columnofelement]);
}

int[,] newArray = CreateRandom2DArray();
Show2DArray(newArray);
  Console.Write("Input number of row: ");
  int row = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input number of columns: ");
  int column = Convert.ToInt32(Console.ReadLine());
ElementPosition(newArray, row, column);
*/

//Task3. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2DArray()
{
  Console.Write("Input amount of rows: ");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input amount of columns: ");
  int columns = Convert.ToInt32(Console.ReadLine());

  int[,] array = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
      array[i, j] = (int)(new Random().Next(0, 100)) / 10;
  return array;
};

void Show2DArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i, j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

void ShowArray(decimal[] array)
{
  for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
  Console.WriteLine();
}

decimal[] AverageofColumns(int[,] array)
{
  decimal[] columnsArray = new decimal[array.GetLength(1)];
  //int[] columnsArray = new int[array.GetLength(1)];
  for (int j = 0; j < array.GetLength(1); j++)
  {
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
      sum += array[i, j];
    columnsArray[j] = Math.Round(sum/(decimal)array.GetLength(0),1);
  }
  return columnsArray;
}

int[,] newArray = CreateRandom2DArray();
Show2DArray(newArray);
decimal[] average = AverageofColumns(newArray);
ShowArray(average);