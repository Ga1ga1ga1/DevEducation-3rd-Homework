//Пользователь вводит 1 число (A).
//Найдите количество положительных целых чисел, квадрат которых меньше A.

int A = Convert.ToInt32(Console.ReadLine());
int iLimit = A;
for (int i = 1; i <= iLimit; i++)
{
    if (i * i <= A)
    {
        Console.WriteLine(i * i);
    }
}

