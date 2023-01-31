// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

/*float factorial(int n)
{
    int x = 1;
    for (int i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}



Console.WriteLine("Введите нужное количество строк треугольника Паскаля:");
string s = Console.ReadLine();
int n = Convert.ToInt32(s);

for(int i = 0; i < n; i++)
{
    for (int c = 0; c <= (n - i); c++) // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отступ
    {
        Console.Write($" "); 
    }
    for (int c = 0; c <= i; c++)
    {
        Console.Write($" "); // создаём пробелы между элементами треугольника
        Console.Write(factorial(i) / (factorial(c) * factorial(i - c))); //формула вычисления элементов треугольника
    }
    Console.WriteLine(); // после каждой строки с числами отступаем две пустые строчки
}

Console.WriteLine("Rows count: ");
int rows = Convert.ToInt32(Console.ReadLine());
 
for (int y = 0; y < rows; y++)
{
    int c = 1;
    for (int q = 0; q < rows - y; q++)
    {
        System.Console.Write(" ");
    }

    for (int x = 0; x <= y; x++)
    {
        System.Console.Write(" {0:D}", c);
        c = c * (y - x) / (x + 1);
    }
    System.Console.WriteLine();
}*/

int[][] jaggedArray = new int[3][];

jaggedArray[0] = new int[5];

Console.Write(jaggedArray[0]);