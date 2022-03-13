//Пользователь вводит 2 числа (A и B).
//Возвести число A в степень B.

int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
long ARaisedPlus = A;
float floatA = A;
float ARaisedMinus = 1 / floatA;
if (B > 1)
{
    while (B != 1)
    {
        B -= 1;
        ARaisedPlus = ARaisedPlus * A;
    }
    Console.WriteLine(ARaisedPlus);
}
else if (B < 0)
{
    while (B != -1)
    {
        ARaisedMinus = ARaisedMinus / floatA;
        B += 1;
    }
    Console.WriteLine(ARaisedMinus);
}
else if (B == 0)
{
    Console.WriteLine(1);
}
