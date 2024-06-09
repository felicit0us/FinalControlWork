// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] inputArray = { "Hello", "2", "world", ":-)" };

void PrintString(string[] strg)
{
    Console.Write('[');
    for (int i = 0; i < strg.Length; i++)
    {
        {
            if (i < strg.Length - 1)
                Console.Write($"{strg[i]}, ");
            else
                Console.Write($"{strg[i]}");
        }
    }
    Console.Write(']');
}

string[] FilterShortStrings(string[] array)
{

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) // Сначала определяем количество строк, длина которых <= 3
        {
            count++;
        }
    }

    string[] resultArray = new string[count]; // Создаём новый массив для хранения результатов
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[index] = array[i];
            index++;
        }
    }

    return resultArray;
}
PrintString(FilterShortStrings(inputArray));
