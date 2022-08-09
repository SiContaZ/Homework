/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []
*/

string[] GetArray3Char(string[] array)
{
    List<string> array3CharLst = new List<string>();

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length>3)
        {
            continue;
        }
        else
        {
            array3CharLst.Add(array[i]);
        }
    }
    string[] array3Char = array3CharLst.ToArray();
    return array3Char;
}

string[] GetArray()
{

    List <string> arrayLst = new List<string>();
    string buffer = string.Empty;
    string result = string.Empty;
    while (true)
    {
        Console.WriteLine("Введите элемент массива. Для прекращения ввода введите \"стоп\"");
        buffer = Console.ReadLine();
        if (buffer == "стоп")
        {
            break;
        }
        else if(buffer == "")
        {
            Console.Clear();
            Console.WriteLine("Вы ничего не ввели. Попробуйте снова");
        }
        else
        {
            Console.Clear();
            arrayLst.Add(buffer);
        }
    }
    string[] array = arrayLst.ToArray();
    return array;
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}



string[] array = GetArray();
string[] array3Char = GetArray3Char(array);

PrintArray(array);
Console.WriteLine();
PrintArray(array3Char);
