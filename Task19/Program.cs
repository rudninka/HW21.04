﻿// Является ли пятизначное число палиндромом
Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int num1 = num/10000;
int num2 = num%10;
int num3 = num/1000%10;
int num4 = num%100/10;
if(num1 == num2 & num3 == num4) 
{
    Console.WriteLine($"Число {num} является палиндромом");
}
else
{
    Console.WriteLine($"Число {num} не является палиндромом");
}
