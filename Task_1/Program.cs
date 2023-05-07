// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Приветствие 
Console.WriteLine("Определение палиндрома ");
// определение переменных 
string number = GetNumberStr("Введите число - ");
string reversedNumber = "";
bool correcnNum;
//определение на правильность ввода числа
//correcnNum = ChechNumber(number);
//Console.WriteLine(correcnNum);
if (ChechNumber(number))
{
//разворот числа
    reversedNumber = ReversString(number);
    //определение числа на палиндром и вывод 
    if (number == reversedNumber) 
        {
        Console.WriteLine(number +" является палиндромом");
        } 
        else 
        {
        Console.WriteLine(number+" не является палиндромом");
        }
}
else
{
   Console.WriteLine("Введено некорректное число"); 
}
// функция ввода числа и возврата в числовом формате
// int GetNumberInt( string text)
// {
//     Console.Write(text);
//     string value = Console.ReadLine ();
//     int number = Convert.ToInt32(value);
//     return number;
// }

// функция ввода числа и возврата в текстовом формате
string GetNumberStr( string text)
{
    Console.Write(text);
    string value = Console.ReadLine ();
    return value;
}
//функция разворота числа
string ReversString ( string str)
{
    string reversStr = "";
    for (int i = str.Length - 1; i >= 0; i--) 
    {
        reversStr += str[i];
    }
    return reversStr;
}

//функция проверки коррестности введенного числа
bool ChechNumber (string value)
{
    int number = Convert.ToInt32(value);
    bool chechNun;
    if (number < 9999 || number > 100000 )
    {
        chechNun = false; 
    }
    else
    {
        chechNun = true;
    }
    return chechNun;
}
