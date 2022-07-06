/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
bool DeterminingNumber(string num)//проверка введены ли числа
{
    foreach (var item in num)
    {
        if (!char.IsDigit(item))
            return false;
    }
    return true;
}
int Long(string lon)// подсчет количества введенных символов
{
    int i = 0;
    foreach (var item in lon)
    {
        i++;
    }
    return i;
}
string Palindrome(string number) //определяет палиндром ли строка
{
    int i = 0;
    foreach (var item in number)
    {
        i++;
    }
    int ind = 0;
    int inde = i - 1;
    string[] str = new string[i];
    string[] rts = new string[i];
    foreach (var item in number)
    {
        // str[ind] = Convert.ToString(item);
        rts[inde] = Convert.ToString(item);
        ind++;
        inde--;
    }
    //Console.WriteLine("[{0}]", string.Join(", ", rts));
    // Console.WriteLine("[{0}]", string.Join(", ", str));
    int a = 0;
    string b = "";
    foreach (var item in number)
    {
        if (rts[a] == Convert.ToString(item)) b = "да";
        else return "нет";
        a++;
    }
    return "да";
}
Console.Clear();
string outputResult;
Console.Write("Введите пятизначное, положительное число: ");
string number = Console.ReadLine();
while (true)
{
    if (!String.IsNullOrEmpty(number) && DeterminingNumber(number) && Long(number) == 5)//проверка на NULL && проверка введено ли число && проверка 5 знаков ли число
    {
        break;
    }
Console.Write("Неверный ввод, введите пятизначное положительное число: ");
number = Console.ReadLine();
}
outputResult = Palindrome(number);//метод определяет палинром ли строка
Console.WriteLine(outputResult);
