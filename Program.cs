﻿/* Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран. */

/* void Fill(int[] fill)
{
    int length = fill.Length;
    int index = 0;
    while (index < length)
    {
        fill[index] = new Random().Next(0, 101);
        index++;
    }
}

void Print(int[] print)
{
    int count = print.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write(" " + print[pos]);
        pos++;
    }
}

int[] arr = new int[8];

 Fill(arr);
 Print(arr); */

/////////////////////////////////////////////


/* Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

/*int A = 359;

int num = A % 10;
int num1 = A / 10 % 10;
int num2 = A /100;
int sum = num + num1 + num2;

Console.WriteLine(sum); */

////////////////////////////////////////////////////

/*Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int A = 2;
int B = 4;
int count = 0;
while (count <= B)
{
int C = A * A; 
int A1=A;
int D = A1 * C ;;

  Console.WriteLine(D);
    count++;
    
}

