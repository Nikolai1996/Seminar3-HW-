// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Equality(int num)
{
       if(num > 10000 && num <100000) 
    {
        int one = num / 10000;
        int two = num / 1000 % 10;
        int three = num / 100 % 10;
        int four = num / 10 % 10;
        int five = num % 10;
        if (one == five && two == four)
        {
             Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }

}

Equality(number);
