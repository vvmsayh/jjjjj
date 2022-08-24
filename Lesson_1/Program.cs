/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
System.Console.Write("введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array  = new int[size];
int EvenNum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
    
}
System.Console.WriteLine($"[ {String.Join(",",array)} ] ");
for (int j = 0; j < array.Length; j++)
{
  if (array[j] % 2 ==0 ) EvenNum+=1;
    
}
System.Console.WriteLine($"Количество четных чисел - {EvenNum}");