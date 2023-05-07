// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Приветствие 
Console.WriteLine("Расчет расстояния между двумя точками в 3D пространстве");
// Определение переменных и инициализация их 
// Ввод координат
int xA = GetNumberInt("Введите координаты первой точки: x - ");
int yA = GetNumberInt("y - ");
int zA = GetNumberInt("z - ");
int xB = GetNumberInt("Введите координаты второй точки: x - ");
int yB = GetNumberInt("y - ");
int zB = GetNumberInt("z - ");

WriteNumber(DitanceAB(Sqr(xA,xB),Sqr(yA,yB),Sqr(zA,zB))); // вычисление расстояния

// функция ввода числа и возврата в числовом формате
int GetNumberInt( string text)
{
    Console.Write(text);
    string value = Console.ReadLine ();
    int number = Convert.ToInt32(value);
    return number;
}

// функция вывода числа
void WriteNumber( double value)
{
    Console.Write(" " + value);
    return;
}

// функция определения квадрата разности двух чисел
double Sqr (int numA, int numB)
{
    double sqr =Math.Pow(numB-numA,2);
    return sqr;
}

// функция вычисления расстояния
double DitanceAB (double x, double y, double z)
{
    double distAB = Math.Round(Math.Sqrt(x+y+z),3);
    return distAB;
}