int Parse(string message)
{
    Console.WriteLine(message);
    string strNum = Console.ReadLine();
    int Num = int.Parse(strNum);
    return Num;
}

int Result(int arg)
{
    int res = 0;
    int temp;
    for (int i = 1; i <= arg; i++)
    {
        temp = Parse($"Введите число {i}");
        if (temp > 0)
        {
            res++;
        }
    }
    return res;
}

int Amount = Parse("Сколько чисел вы хотите ввести: ");
Console.WriteLine($"Чисел больше нуля - {Result(Amount)}");
