// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Приветствие 
Console.WriteLine("Вывод таблицы кубов от 1 до введенного числа");

// определение переменных и инициализация их
int cubeNumber = GetNumber();
int cubeIndex = 1;
int cube;

while (cubeIndex < cubeNumber + 1)
{
    cube = GetCubeNumber(cubeIndex);
    WriteNumber(cube);
    cubeIndex = cubeIndex + 1;
}

// функция ввода числа и возврата в числовом формате
int GetNumber()
{
    Console.Write("Введите число - ");
    string value = Console.ReadLine ();
    int number = Math.Abs(Convert.ToInt32(value)); // число передаем по модулю
    return number;
}

// функция вывода числа
void WriteNumber( int value)
{
    Console.Write(" " + value);
    return;
}

// функция вычисления куба числа
int GetCubeNumber( int number)
{
    int cubeNum = Convert.ToInt32(Math.Pow(number,3)); 

    return cubeNum;
}