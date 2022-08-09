// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
//Console.Clear();
Console.WriteLine("Введите любое число, чтобы потом вывести третью цифру этого числа ");
Console.Write("Ваше число: ");
int number = Convert.ToInt32(Console.ReadLine());

string numberText = Convert.ToString(number); //Convert.ToString() функция, которая для числа даёт его строковое представление.

if (numberText.Length > 2)
    {
        Console.WriteLine($"Третья цифра числа '{number}' -> " + numberText[2]);
    }
else 
    {
        Console.WriteLine($"В введенном числе '{number}' третьей цифры нет");
    }