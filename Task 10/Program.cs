//Пользователь вводит 1 число.
//Найти число, которое является зеркальным отображением последовательности
//цифр заданного числа, например, задано число 123, вывести 321.
int number = Convert.ToInt32(Console.ReadLine());
int newNumber = 0;
while (number != 0)
{
    newNumber = newNumber * 10 + number % 10; 
    number /= 10;
}
Console.WriteLine(newNumber);