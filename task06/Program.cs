﻿/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/


int [] CreateArray(int Length, int min, int max)
{
int [] numbers = new int [Length];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(min,max +1);
}
return numbers;
}

void PrintArray(int [] numbers)
{
System.Console.Write("[");
for (int i = 0; i < numbers.Length -1; i++)
{
    System.Console.Write(numbers[i] + "; ");
}
System.Console.WriteLine(numbers[numbers.Length -1] + "]");
}

int Num (string arg)
{
    System.Console.WriteLine($"Введите {arg} ");
    return int.Parse(System.Console.ReadLine());
}

void PositivSum (int [] numbers)
{
    int count = numbers.Length-1;
    int work = 0;
    for (int i = 0; i < numbers.Length/2; i++)
    {
        work = numbers[i] * numbers[count];
        count--;
        System.Console.WriteLine(work);
        /*if (numbers.Length % 2 == 0)
        {
            break;
        }
        else System.Console.WriteLine(numbers[numbers.Length/2+1]);*/
    }
    
}

int Length = Num("длину массива");
int min = Num("меньшее число");
int max = Num("максимальное число");
int [] numbers = CreateArray(Length, min, max);
PrintArray(numbers);
PositivSum(numbers);



/*int Length = Num("длину массива");
int min = Num("меньшее число");
int max = Num("максимальное число");
int num = Num("Искомое число");
int [] numbers = CreateArray(Length, min, max);
PrintArray(numbers);
System.Console.WriteLine(PositivSum(numbers, num));*/













