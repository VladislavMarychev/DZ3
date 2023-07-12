// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Task19()
{
    int Vvod(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());

    }
    int number = Vvod("Введите число пятизначное  ");

    if (number < 10000 || number > 99999)
    {
        Console.WriteLine("Число {0} не пятизначное", number);

    }
    else if (number > 10000 || number < 99999)
    {
        int NumberA = number % 10;
        int NumberB = number / 10000;
        int NumberC = number / 10 % 10;
        int NumberD = number / 1000 % 10;
        if (NumberA == NumberB && NumberC == NumberD)
        {
            Console.WriteLine("Число палиндром  ", number);
        }
        else
            Console.WriteLine("Число не палиндром", number);
    }
}
Console.Clear();
Task19();