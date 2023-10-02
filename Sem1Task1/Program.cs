//Задача 1. Напишите программу , которая на вход принимает два числа и проверяет
//является ли перве квадратом ворого.

Console.WriteLine("Введите первое число :");
int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите втрое число: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");

if (num1 * num1 == num2)
{
    Console.WriteLine("Первое число квадрат второго");
}
else
{
    Console.WriteLine("Неверно, первое число не является квадратом второго.");

}
//Решение в1 строку
//Console.WriteLine(num1 == Math.Pow(num2,2)? "Да" : "Нет");
//  (Условие)<если перно вариант 1> : <если неверно вариатн 2> 