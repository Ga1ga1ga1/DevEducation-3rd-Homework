//Пользователь вводит 1 положительное число (N).
//Выведите N-ое число ряда фибоначчи.
//В ряду фибоначчи каждое следующее число является суммой двух предыдущих.
//Первое и второе считаются равными 1.

int N = Convert.ToInt32(Console.ReadLine());
int previousFibonacci = 1;
int nextFibonacci = 1;
int tmp = 0;
for (int i = 3; i <= N; i++)
{
    tmp = previousFibonacci + nextFibonacci;
    previousFibonacci = nextFibonacci;
    nextFibonacci = tmp;

}
Console.WriteLine(tmp);
