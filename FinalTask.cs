// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] arrayInput = { "hello", "2", "world", ":-)" };
//string[] arrayInput = { "1234", "1567", "-2", "computer science" };
//string[] arrayInput = { "Russia", "Denmark", "Kazan" };

int countString = CountStringThreeChar(arrayInput);
string[] arrayOutput = FillOutputArray(arrayInput, countString);

PrintArray(arrayInput);
PrintArray(arrayOutput);

void PrintArray(string[] array) // Функция вывода массива в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else Console.Write($"{array[i]}.");
    }
    Console.WriteLine();
}

int CountStringThreeChar(string[] array) // Функция считает строки, длинною 3 символа и меньше.
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] FillOutputArray(string[] array, int count)
{
    string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[result.Length - count] = array[i];
            count--;
        }
    }
    return result;
}
