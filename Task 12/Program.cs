//Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел
//одинаковые цифры. Например, для пары 123 и 3456789,
//ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.

int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
int firstTmp = 0;
int secondTmp = 0;
bool matchedDigit = false;

for (int i = firstNumber; i != 0; i /= 10)
{
    firstTmp = i % 10;
    for (int j = secondNumber; j != 0; j /= 10)
    {
        secondTmp = j % 10;
        if (firstTmp == secondTmp)
        {
            matchedDigit = true;
        }
    }
}
Console.WriteLine(matchedDigit ? "ДА" : "НЕТ");