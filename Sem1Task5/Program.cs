// Задача 5. Напишите программу , которая на вход принимает число N,
//а на выходе показывает все целые числа от -N до N.

Console.WriteLine("Введите число:");

int numN = int.Parse (Console.ReadLine()??"0");

int evenNum = (-1) * numN ;//  новая переменная для получения отрицательных чисел

while (evenNum < numN )
{
    Console.Write (evenNum + ",");
    evenNum++;
}
Console.WriteLine(evenNum);
