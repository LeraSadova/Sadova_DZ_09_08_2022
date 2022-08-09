// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//Console.Clear();
Console.WriteLine("Определим, является ли выбранный день недели выходным?");
Console.WriteLine("Введите номер дня недели, где ");

Console.WriteLine("1 - ПН, 2- ВТ, 3 - СР, 4 - ЧТ, 5 - ПТ, 6 - СБ, 7 - ВС");
int day=Convert.ToInt32(Console.ReadLine());
// я реализую вывод через конструкцию swish. Опять же - в условиях ДЗ не указаны требования к исполнению
switch (day) //и да, я пишу подробный текст вывода. Так считаю наглдянее и понятнее будет другим. 
{
    case 1:
    Console.WriteLine("Нет, понедельник не выходной");
     break;
    case 2:
    Console.WriteLine("Нет, вторник не выходной");
     break;
    case 3:
    Console.WriteLine("Нет, среда не выходной");
     break;
    case 4:
    Console.WriteLine("Нет, четверг не выходной");
     break;
    case 5:
    Console.WriteLine("Нет, пятница не выходной");
     break;
    case 6:
    Console.WriteLine("ДА! Суббота - это выходной");
     break;
    case 7:
    Console.WriteLine("ДА! Воскресенье - это выходной"); 
     break;

    default: Console.WriteLine("ошибка");
     break;
}
