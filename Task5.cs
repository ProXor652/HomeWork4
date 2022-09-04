/* //Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int size = 10;
int min = -999;
int max = +999;
int[] array = new int[size];

int count = 0;

for (int i = 0; i < array.Length; ++i)
{
    array[i] = new Random().Next(min,max+1);
}

Console.WriteLine(string.Join(",", array));

for (int i = 0; i < array.Length; ++i)
 {
   if(array[i]%2 == 0)
    {
    count ++;
    }
 }

Console.WriteLine("Quantity not even numbers: " + count); */

/* //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int size = 10;
int min = -999;
int max = +999;
int[] array = new int[size];

for (int i = 0; i < array.Length; ++i)
{
    array[i] = new Random().Next(min,max+1);
}

Console.WriteLine(string.Join(",", array));
int CetNumSum = 0;
foreach(int el in array)
 {
 CetNumSum += el%2 == 1 ? el : 0;
 }

Console.WriteLine("Quantity not even numbers: " + CetNumSum); */

/* //Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int size = 10;
int minMass = 0;
int maxMass = +999;
int[] array = new int[size];

for (int i = 0; i < array.Length; ++i)
{
    array[i] = new Random().Next(minMass,maxMass+1);
}

Console.WriteLine(string.Join(",", array));

int min = array[0];

for(int i = 0; i < array.Length; ++i)
 {
    if(min>array[i])
    {
    min = array[i];
    }
 }
  Console.WriteLine("Min number massiva: " + min);

int max = array[0];

for(int i = 0; i < array.Length; ++i)
 {
    if(max<array[i])
    {
    max = array[i];
    }
 }
  Console.WriteLine("Max number massiva: " + max);

int raz= max-min;

Console.WriteLine("Different number max and min ravna:" + raz); */