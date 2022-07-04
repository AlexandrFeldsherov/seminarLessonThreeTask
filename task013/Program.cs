/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

int ThreeDigital(int num)
{
    num = Math.Abs(num);
    int numN = 1;
    int numMin = num;
    while (numMin / 100 > 0)
    {
        numN = numMin % 10;
        numMin = numMin / 10;
    }
    return num / 100 > 0 ? numN : -1;
}
Console.Write("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());
int numberOutput = ThreeDigital(number);
string output = numberOutput < 0 ? $"{number} -> третьeй цифры нет" : $"{number} -> {numberOutput}";
Console.WriteLine(output);