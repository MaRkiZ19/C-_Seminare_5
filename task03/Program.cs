/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/



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

bool PositivSum (int [] numbers, int num)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] == num)
        {
            return true;
        }
    }
    return false;
}


int Length = Num("длину массива");
int min = Num("меньшее число");
int max = Num("максимальное число");
int num = Num("Искомое число");
int [] numbers = CreateArray(Length, min, max);
PrintArray(numbers);

System.Console.WriteLine(PositivSum(numbers, num));

