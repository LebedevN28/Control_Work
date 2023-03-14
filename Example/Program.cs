// Задача: Написать программу, которая из имеющегося массива 
// строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.

Console.Clear();

void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.Write("Введите количество строк в массиве: ");
int n = int.Parse(Console.ReadLine()!);

string[] array1 = new string[n];
Console.WriteLine("Введите строки массива:");
for (int i = 0; i < n; i++)
{
    array1[i] = Console.ReadLine();
}
string[] array2 = new string[array1.Length];
SecondArrayWithIF(array1, array2);
Console.WriteLine("Массив строк, длина которых не более 3 символов: ");
PrintArray(array2);
