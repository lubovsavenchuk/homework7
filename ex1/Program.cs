// Задайте двумерный массив размером m×n, заполненный случайными вещественными (тип double) числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double [,] array = new double [m, n];
Random rnd = new Random();

for(int i = 0; i < m; i++)
{
   for(int j = 0; j < n; j++)
   {
      array[i, j] = rnd.NextDouble() * 100;
      Console.Write(array [i, j] + " ");
   }
   Console.WriteLine();
}
