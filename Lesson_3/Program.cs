/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
System.Console.Write("введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array  = new double[size];
double NumMax = array[0];
double Diff = 0;
Random rand = new Random();
for (int i = 0; i < size; i++)
{
    array [i] =(double) rand.NextDouble()*100;
    array[i] = Math.Round(array[i],0);
}
System.Console.WriteLine($"[ {String.Join(" ; ",array)} ] ");
for (int j = 0; j < size; j++)
{
    if(array[j]>NumMax) NumMax = array[j];
}
double NUmMin = array[0];
for (int k = 0; k < size; k++)
{
    if(array[k]<NUmMin) NUmMin = array[k];
}

Diff = NumMax - NUmMin;
System.Console.WriteLine($"Разницу между максимальным [ {NumMax} ] и минимальным [ {NUmMin} ] элементов массива равна: {Diff} ");