//Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет. Не использовать string[]
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.Write("Введите натуральное число: ");
int number = int.Parse(Console.ReadLine());
int low = 100;
int up = 999;
int count = 0;

if (number < low)
{
    Console.WriteLine("Третьей цифры нет"); 
}
else
{
    if (number <= up)
    {
        int result1 = number % 10;
        Console.WriteLine(result1);
    }
    if (number > up)
    {
        for(count = 0; count < 100 ; count++)
        {
            int result2 = number % 100;
            Console.WriteLine(result2);
            break;
        }
    }
}
