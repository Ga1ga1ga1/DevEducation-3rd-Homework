//Пользователь вводит 1 число.
//Найти количество нечетных цифр этого числа.
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (number != 0)
{
    if (number % 2 != 0)
    {
        number /= 10;
        count++;
    }
    else
    {
        number /= 10;
    }
}
Console.WriteLine(count);
