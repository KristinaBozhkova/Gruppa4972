//Задача 3. Напишите программу , которая будет печатать день недели 
//по указанному номеру.
//Решение спомощьюмассива

Console.WriteLine("Введите номер:");

int day = int.Parse(Console.ReadLine()??"0");

string [] dayOfWeek = new string [7]; //объявляем массив с заданной длинной 7

dayOfWeek [0] = "Понедельник";
dayOfWeek [1] = "Вторник";
dayOfWeek [2] = "Среда";
dayOfWeek [3] = "Четверг";
dayOfWeek [4] = "Пятница";
dayOfWeek [5] = "Суббота";
dayOfWeek [6] = "Воскресенье";

if (day <=7)  //условие выполнения
{
Console.WriteLine( dayOfWeek [day-1]);
}
else
 {
Console.WriteLine( "Номер введен неверно,повторите попытку и введите номер от 1 до 7");
}
