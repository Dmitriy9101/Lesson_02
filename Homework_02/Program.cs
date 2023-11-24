// Напишите программу которая принимает на вход два числа
// и проверяет является ли первое число квадратом второго

// Console.Write("Введите первое число число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// if (secondNumber == firstNumber * firstNumber)
// {
//     Console.WriteLine($"{secondNumber},{firstNumber} -> да");
// }
// else
// {
//     Console.WriteLine($"{secondNumber},{firstNumber} -> нет");
// }

// Напишите программу, которая принимает на вход координаты точки 
// (X и Y), причем х неравен нулю и y неравен нулю и выдаёт номер
// координатной четверти плоскости, в которой находится эта точка

// Console.Write("Введите первое число число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber > 0 && secondNumber > 0) // 1 четверть
// {
//     Console.WriteLine("Точка находится в первой четверти");
// }
// else if (firstNumber < 0 && secondNumber > 0) // 2 четверть
// {
//     Console.WriteLine("Точка находится во второй четверти");
// }
// else if (firstNumber < 0 && secondNumber < 0) // 3 четверть
// {
//     Console.WriteLine("Точка находится в третьей четверти");
// }
// else if (firstNumber > 0 && secondNumber < 0) // 4 четверть
// {
//     Console.WriteLine("Точка находится в четвёртой четверти");
// }

// Задача 3. Напишите программу которая выводит третью цифру с начала
// заданного числа или сообщает что третьей цифры нет (Сделал до любой 7-значной цифры)

// Console.Write("Введите число: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// if (Number < 1000 && Number > 0)
// {
// int vivod = Number % 10;
// Console.WriteLine($"Третья цифра заданного числа {vivod}");
// }
// else if (Number >= 1000 && Number < 10000 )
// {
//     int vivod = Number / 10;
//     int vivod2 = vivod % 10;
//     Console.WriteLine($"Третья цифра заданного числа {vivod2}");
// }
// else if (Number >= 10000 && Number < 100000 )
// {
//     int vivod = Number / 100;
//     int vivod2 = vivod % 10;
//     Console.WriteLine($"Третья цифра заданного числа {vivod2}");
// }
// else if (Number >= 100000 && Number < 1000000 )
// {
//     int vivod = Number / 1000;
//     int vivod2 = vivod % 10;
//     Console.WriteLine($"Третья цифра заданного числа {vivod2}");
// }

// Задача 4. Напишите программу которая на вход принимает натуральное
// число N, а на выходе показывает его цифры через запятую

// Console.Write("Введите 4-х значное число число: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// int firstNumber = Number / 1000; // находим первое число
// int a = Number / 100; 
// int secondNumber = a % 10; // Находим второе число
// int b = Number / 10;
// int thirdNumber = b % 10;
// int fourNumber = Number % 10;
// Console.WriteLine($"{Number} -> {firstNumber},{secondNumber},{thirdNumber},{fourNumber}");