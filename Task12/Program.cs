// 1. принимать на вход два числа
// 2. выводить, является ли второе число кратным первому. 
// 3. Если число 1 не кратно числу 2, топрограмма выводит остаток от деления.
// Например: 34, 5 -> не кратно, остаток 4; 16, 4 -> кратно

Console.WriteLine("Введите первое целое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber % secondNumber == 0)
{
Console.WriteLine($"Число {firstNumber} кратно {secondNumber}");
}
else
{
    Console.WriteLine($"Число {firstNumber} не кратно {secondNumber}, остаток {firstNumber % secondNumber}");
}
