//  1. которая выводит случайноt трёхзначное число 
// 2. удаляет вторую цифру этого числа.
// Например: 456 -> 46; 782 -> 72; 918 -> 98
// 12 мин

int number = new Random().Next (100, 1000);
Console.Write($"Случайное техзначное число: {number}");

int firstDigit = number / 100;
int thirdDigit = number % 10;
int resalt = firstDigit * 10 + thirdDigit;

Console.Write($" => {resalt}");