// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int InitialData(string word)
{
    Console.Write(word);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int FindSumNumbersFromNToM(int m1, int n1)
{
    if (n1 < m1 || n1 <= 0 && m1 <= 0)
    {
        Console.WriteLine($"Диапазон чисел введен некорректно или в указанном диапазоне нет натуральных чисел!");
        return default;
    }

    else if (m1 <= 0)
    {
        if (n1 == 1) return 1;
        return n1 += FindSumNumbersFromNToM(m1, --n1);
    }

    else
    {
        if (m1 == n1) return m1;
        return n1 += FindSumNumbersFromNToM(m1, --n1);
    }
}

int numberM = InitialData("Введите первое натуральное число: ");
int numberN = InitialData("Введите второе натуральное число: ");

Console.WriteLine($"Сумма натуральных чисел в диапазоне от {numberM} до {numberN} равна: {FindSumNumbersFromNToM(numberM, numberN)}");