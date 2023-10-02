// Задача 0
//Напишите программу которая на вход принимает число,а на выходе
//выдает его квадрат.

Console.WriteLine("Введите число: ");

String inputNum = Console.ReadLine()??"0"; // ??"0" - проверка на null

//int num = int.Parse(inputNum); // перевод из строки в число

//int resalt = num * num; //определяем квадрат

//Console.WriteLine("Квардар числа равен:"+ resalt); // печать результата

Console.WriteLine("Квадрат числа :" + (int)Math.Pow(int.Parse(inputNum),2));// вариант решения при помощи Math.Pow



