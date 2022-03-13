// Пользователь вводит 2 числа.
// Найти их наибольший общий делитель используя алгоритм Евклида.
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
int tmp = 0;

if (firstNumber > secondNumber)
{
    tmp = firstNumber;
    firstNumber = secondNumber;
    secondNumber = tmp;
}
while (firstNumber != 0)
{
    tmp = firstNumber;
    firstNumber = secondNumber % firstNumber;
    secondNumber = tmp;
}
Console.WriteLine(secondNumber);
