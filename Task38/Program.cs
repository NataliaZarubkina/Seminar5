//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int length = GetNumberFromUser("Введите длину массива: ", "Ошибка ввода!");
int min = GetNumberFromUser("Введите начальное значение диапазона: ", "Ошибка ввода!");
int max = GetNumberFromUser("Введите конечное значение диапазона: ", "Ошибка ввода!");
double[] array = GetArray(length, min, max);
double maxNumber = FindMaxNumber(array);
double minNumber = FindMinNumber(array);
double result = FindDiffNumbers(minNumber, maxNumber);
Console.WriteLine($"[{String.Join(", ", array)}] -> {result}");

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

double FindMaxNumber(double[] array)
{
    int length = array.Length;
    double max = array[0];
    for (int i = 1; i < length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

double FindMinNumber(double[] array)
{
    int length = array.Length;
    double min = array[0];
    for (int i = 1; i < length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

double FindDiffNumbers(double minNumber, double maxNumber)
{
    double result = maxNumber - minNumber;
    return result;
}