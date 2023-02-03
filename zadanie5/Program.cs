using System;

public class Mainclass
{
    public static void Main()
    {
    c:
        Console.WriteLine("Введите номер месяца:");
        int month = int.Parse(Console.ReadLine());
        if (month >= 1 && month <= 12)
        {
            Console.WriteLine("Год високосный? 1) Да; 2) Нет");
            int vis = int.Parse(Console.ReadLine());
            if (vis == 1 && month == 2)
            {
                Console.WriteLine("Февраль: 29 дней");
            }
            else
            {
                switch (month)
                {
                    case 1:
                        Console.WriteLine("Январь: 31 день");
                        break;
                    case 2:
                        Console.WriteLine("Февраль: 28 дней");
                        break;
                    case 3:
                        Console.WriteLine("Март: 31 день");
                        break;
                    case 4:
                        Console.WriteLine("Апрель: 30 дней");
                        break;
                    case 5:
                        Console.WriteLine("Май: 31 день");
                        break;
                    case 6:
                        Console.WriteLine("Июнь: 30 дней");
                        break;
                    case 7:
                        Console.WriteLine("Июль: 31 день");
                        break;
                    case 8:
                        Console.WriteLine("Август: 30 дней");
                        break;
                    case 9:
                        Console.WriteLine("Сентябоь: 31 день");
                        break;
                    case 10:
                        Console.WriteLine("Октябрь: 30 дней");
                        break;
                    case 11:
                        Console.WriteLine("Ноябрь: 31 день");
                        break;
                    case 12:
                        Console.WriteLine("Декабрь: 31 день");
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Такого месяца не существует, попробуйте снова");
            goto c;
        }
    }
}