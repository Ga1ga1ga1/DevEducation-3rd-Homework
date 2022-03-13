//Пользователь вводит 2 числа (A и B).
//Вывести сумму всех чисел из диапазона от A до B,
//которые делятся без остатка на 7.
//(Учтите, что при вводе B может оказаться меньше A).

int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int limit1 = A;
int limit2 = B;
if (A == B)
{
    if (A % 7 == 0)
    {
        Console.WriteLine(A);
    }
    else
    {
        Console.WriteLine("Нет чисел, делящихся на 7");
    }
}
else if (B - A > 0)
{
    for (int i = limit1; i <= limit2; i += 7)
    {
        if (i != 0 && i % 7 == 0)
        {
            Console.WriteLine(i);
        }
    }
}
else if (A - B > 0)
{
    for (int i = limit2; i <= limit1; i += 7)
    {
        if (i != 0 && i % 7 == 0)
        {
            Console.WriteLine(i);
        }
    }
}
