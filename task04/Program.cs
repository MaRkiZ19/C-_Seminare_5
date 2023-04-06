// расчёт интеграла    y = k * x + b

using System;
DateTime now = DateTime.Now;

int k = 5;
int b = 4;

int x0 = 0;
int xLast = 1500;
double offset = 0.00001;

double result = 0;
int count = 0;
for (double i = x0; i < xLast; i+= offset)
{
    double rectangleSquare = ((offset + i) * k + b) * offset;
    result += rectangleSquare;
    count ++;
}
DateTime end = DateTime.Now;
System.Console.WriteLine(result);
System.Console.WriteLine(count);
System.Console.WriteLine(end - now);