// Напишите программу, которая на вход принимает позиции (две) элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


int [,] table = new int [3,4];
Random rnd = new Random();

for(int i = 0; i < table.GetLength(0); i++)
{
   for(int j = 0; j < table.GetLength(1); j++)
   {
      table[i, j] = rnd.Next(50);
      Console.Write(table [i, j] + " ");
   }
   Console.WriteLine();
}
Console.WriteLine("Введите позицию элемента: ");
int position1 = Convert.ToInt32(Console.ReadLine());
int position2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("table ["+position1+", "+position2+"] = " + table [position1, position2]);
if(position1 >= table.Length && position2 >= table.Length)
{
   Console.WriteLine("Данный элемент не найден");

}
