// Напишите программу которая выводит случайное число из отрезка
// (10,99) и показывает наибольшую цифру числа

int number = new Random().Next(10, 100); //[10,99] или [10,100)
// Console.WriteLine($"Рандомное число из диапазона [10,99]: {number}");

int firstDigit = number / 10; // 78/10 = 7
int secondDigit = number % 10; // 78%10 = 8

// Console.WriteLine($"1 цифра: {firstDigit}, 2 цифра: {secondDigit}");

// int max = firstDigit; // Пусть максимум - 1 цифра числа
if (secondDigit > max) // 8 > max(7)
{
    max = secondDigit; // max=8
}
Console.WriteLine($"Максимальная цифра в числе {number}: {max}");