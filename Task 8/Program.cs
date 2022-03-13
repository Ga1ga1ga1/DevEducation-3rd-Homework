//Пользователь вводит целое положительное число,
//которое является кубом целого числа N.
//Найдите число N методом половинного деления.
int N = Convert.ToInt32(Console.ReadLine());
int leftBorder = 0;
int rightBorder = N;
int tmp = 0;
while (tmp * tmp * tmp != N)
{
    tmp = (leftBorder + rightBorder) / 2;
    if (tmp * tmp * tmp > N)
    {
        rightBorder = tmp;
    }
    else
    {
        leftBorder = tmp;
    }
}
Console.WriteLine(tmp);
