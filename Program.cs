// Напишите программу которая выводит случайное число из отрезка
// (10,99) и показывает наибольшую цифру числа

// int number = new Random().Next(10, 100); //[10,99] или [10,100)
// // Console.WriteLine($"Рандомное число из диапазона [10,99]: {number}");

// int firstDigit = number / 10; // 78/10 = 7
// int secondDigit = number % 10; // 78%10 = 8

// // Console.WriteLine($"1 цифра: {firstDigit}, 2 цифра: {secondDigit}");

// int max = firstDigit; // Пусть максимум - 1 цифра числа
// if (secondDigit > max) // 8 > max(7)
// {
//     max = secondDigit; // max=8
// }
// Console.WriteLine($"Максимальная цифра в числе {number}: {max}");

// Напишите программу, которая выводит случайное трёхзначное число и
// удаляет вторую цифру этого числа
// 468 ->48
// [100, 1000] => 100-999
// int number = new Random().Next(100, 1000);
// // 456 / 100 = 4
// // 456 % 10 = 6
// int firstDigit = number / 100; // 456 / 100 = 4
// int thirdDigit = number % 10; // 456 % 10 = 6
// int vivod =(firstDigit * 10 + thirdDigit);
// Console.WriteLine($"{number} -> {vivod}");

// Напишите программу которая принимает на вход число и проверяет
// кратно ли оно 7 и 23 одновременно. Если число не кратно 7 и 23
// то программа выводит остаток от деления.

// 14-> нет 
//46 -> нет
// 161 -> да

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// // "&&" - "И" , (14 % 2 == 0) & (14 % 7 == 0)
// // апельсины и яблоки (обязательно выполнить оба условия)
// // "||" - "Или" (Хотя бы одно условие - истина)
// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine($"Да, число {number} кратно 7 и 23");
// }
// else
// {
//     Console.WriteLine("Не кратно");
//     Console.WriteLine($"Остаток от деления {number} на 7 = {number % 7}");
//     Console.WriteLine($"Остаток от деления {number} на 23 = {number % 23}");
// }