//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Vvod(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());

    }

    int number = Vvod ("Введите число");

    int index = 1;
    while (index <= number)
    {
        Console.WriteLine ($"{index}^3 = {Math.Pow(index, 3)} ");
        index++;
    }
