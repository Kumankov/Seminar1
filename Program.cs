Task10 ();
void Task10 ()
{
Console.WriteLine("Введите трехзначное число для задачи 10:");
int N = int.Parse(Console.ReadLine());
if (Math.Abs(N)>999 || Math.Abs(N)<100)
{
    Console.WriteLine($"Число {N} не трехзначное");
}
else 
{
    Console.WriteLine($"Вторая цифра {(N%100-N%10)/10}");
}
}

Task13();
void Task13 ()
{
Console.WriteLine("Введите число для задачи 13:");
string? N13 = Console.ReadLine();
int lenght = N13.Length;
if (lenght<3)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine($"Третья цифра {N13.Substring(2,1)}");
}

Task15();
void Task15 ()
{
Console.WriteLine("Введите номер дня недели для задачи 15:");
int day = int.Parse(Console.ReadLine());
if ((day==6)||(day==7))
Console.WriteLine("Выходной");
else
{
    if ((day>1)&&(day<6))
    Console.Write("Не выходной");
    else
     Console.Write("Некорректный номер");
}
}