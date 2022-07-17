// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
string VerifPalindr(int num)
{
    int[] array = new int[5];
    string result = string.Empty;
    int temp_num = num;
    for (int i = 0; i < 5; i++)
    {
        array[i] = temp_num % 10;
        temp_num /= 10;
    }
    for (int i = 0; i < 2; i++)
    {
        if (array[i] == array[4 - i]) result = $"да, число - {num} является палиндромом ";
        else result = $"нет, число - {num} не является палиндромом"; break;
    }
    return result;
}

Console.Write("Введите пятизначное число:  ");
int number = int.Parse(Console.ReadLine());

if (number <= 99999) Console.WriteLine(VerifPalindr(number));
else Console.WriteLine("ошибочный ввод");