//*Пользователь вводит целое положительное  число (N).
//Выведите числа в диапазоне от 1 до N,
//сумма четных цифр которых больше суммы нечетных. 
int N = Convert.ToInt32(Console.ReadLine());
int sumOdd = 0;
int sumEven = 0;
for (int i = 0; i <= N; i++)
{
    int tmp = i;
    while (tmp > 0)
    {
        int tmp2 = tmp % 10;
        tmp /= 10;
        if (tmp2 % 2 != 0)
        {
            sumOdd = sumOdd + tmp2;
        }
        else
        {
            sumEven = sumEven + tmp2;
        }
    }
    if (sumEven > sumOdd)
    {
        Console.WriteLine(i);
    }
    sumOdd = 0;
    sumEven = 0;
}
