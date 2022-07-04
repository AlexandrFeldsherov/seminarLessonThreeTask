/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

int ThreeDigital(int num)
{
    int numN = num / 100 % 10;
    numN = Math.Abs(numN);
    return (int)Math.Log10(Math.Abs(num)) > 1 ? numN : -1;
}
Console.Write("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());
int numberOutput = ThreeDigital(number);
string output = numberOutput < 0 ? $"{number} -> третьeй цифры нет" : $"третья цифра числа {number} -> {numberOutput}";
Console.WriteLine(output);