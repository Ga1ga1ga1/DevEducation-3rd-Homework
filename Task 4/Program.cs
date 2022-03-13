//Пользователь вводит 1 число (A).
//Вывести наибольший делитель (кроме самого A) числа A.
int A = Convert.ToInt32(Console.ReadLine());
int largestDivisor = 0;
for (int i = 2; i < A; i++)
{
    if(A % i == 0)
    {
        largestDivisor = A / i;
        Console.WriteLine(largestDivisor);
        break;
    }
}