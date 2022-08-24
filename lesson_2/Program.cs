/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
System.Console.Write("введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array  = new int[size];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,21);
    if (i%2==1)
    {
     sum+=array[i];
    }
}
System.Console.WriteLine($"[ {String.Join(",",array)} ] ");
System.Console.WriteLine($"Сумма элементов: {sum} ");