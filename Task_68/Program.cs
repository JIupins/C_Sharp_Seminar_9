// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int InitialData(string word)
{
    Console.Write(word);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int AccermanFunctionSolution(int m, int n)
{
    if (m < 0 || n < 0)         return 0;

    else if (m == 0)            return n + 1;

    else if (m > 0 && n == 0)   return AccermanFunctionSolution(m - 1, 1);

    else if (m > 0 && n > 0)    return AccermanFunctionSolution(m - 1, AccermanFunctionSolution(m, n - 1));

    else return 0;
}

int numM = InitialData("Введите первый аргумент функции Аккермана (m): ");
int numN = InitialData("Введите второй аргумент функции Аккермана (n): ");

if      (AccermanFunctionSolution(numM, numN) == 0) Console.WriteLine($"Функция Аккермана вида A({numM}, {numN}) не имеет решения!");
else    Console.WriteLine($"Функция Аккермана вида А ({numM}, {numN}) равна: {AccermanFunctionSolution(numM, numN)}");