//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int length = GetLenghtFromUser("Введите длину массива: ", "Ошибка ввода!");
int min = GetRangeFromUser("Введите трехзначное число начала диапазона: ", "Ошибка ввода!");
int max = GetRangeFromUser("Введите трехзначное число конца диапазона: ", "Ошибка ввода!");
int[] array = GetArray(length, min, max);
int result = EvenNumbers(array);
Console.WriteLine($"[{String.Join(", ", array)}] -> {result}");

int GetLenghtFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber >0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetRangeFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber >99 && userNumber < 1000)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int EvenNumbers(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        int res = el%2;
        if (res == 0)
            count++;
    }
    return count;
}