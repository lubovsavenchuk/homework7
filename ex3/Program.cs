// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int N = Convert.ToInt32(Console.ReadLine());
int M = Convert.ToInt32(Console.ReadLine());
int [,] a = new int [N, M];
Random rnd = new Random();
int [] sum = new int [M];

for(int i = 0; i < a.GetLength(0); i++)
{
   for(int j = 0; j < a.GetLength(1); j++)
   {
      a [i, j] = rnd.Next(10);
      Console.Write(a [i, j] + " ");
      sum [i] += a[j, i];
      
   }
   Console.WriteLine();
}
double avg = 0;
for(int i = 0; i < sum.Length; i++)
{
   avg = avg + (double)sum [i] / M;
}
Console.WriteLine("Среднее арифметическое = " + avg);