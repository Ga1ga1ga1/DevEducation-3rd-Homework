// See //Пользователь вводит 1 число (A).
//Вывести все числа от 1 до 1000, которые делятся на A.

int A = Convert.ToInt32(Console.ReadLine());
int tmp = A;
int iLimit = 1000 / tmp * tmp;

for (int i = 0; i < iLimit; i += tmp)
{
    Console.WriteLine(A);
    A += tmp;
}
