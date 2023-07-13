 //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

 double Vvod(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt64(Console.ReadLine());

    }


double x1 = Vvod("Введите значение X первой точки:  ");
double y1 = Vvod("Введите значение Y первой точки:  ");
double z1 = Vvod("Введите значение Z первой точки:  ");
double x2 = Vvod("Введите значение X второй точки:  ");
double y2 = Vvod("Введите значение Y второй точки:  ");
double z2 = Vvod("Введите значение Z второй точки:  ");

double result = Math.Sqrt(Math.Pow((x2 -x1), 2 ) + Math.Pow((y2 -y1), 2 ) + Math.Pow((z2 -z1), 2 ));
result = Math.Round(result, 2);
Console.WriteLine($"Расстрояние между точками {result} " );
