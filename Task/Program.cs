// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(string [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива:");
        arr[i] = Console.ReadLine();
    }
}

void ShowArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length-1]}");
    Console.Write("]");
}

int GetSizeNewArr(string[] arr)
{
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            n++;
        }
    }
    return n;
}

int size = ReadInt("Введите длину массива > ");
string[] array = new string[size];
FillArray(array);
ShowArray(array);
System.Console.WriteLine();
if (GetSizeNewArr(array) == 0)
{
    System.Console.WriteLine("В заданном массиве нет строк, длина которых меньше либо равна 3 символам =(");
}
else
{
    string[] new_array = CreatArray(array);
    ShowArray(new_array);
}

string[] CreatArray(string[] arr)
{
    string[] new_array = new string[GetSizeNewArr(array)];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            new_array[j] = arr[i];
            j++;
        }
    }
    return new_array;
}

