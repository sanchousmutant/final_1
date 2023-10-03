
string[] CreateArray() // создание массива
{
    System.Console.Write("Через пробел вводите данные: ");
    string[] array = Console.ReadLine()!.Split();
    return array;
}

void PrintArray(string[] array) // вывод массива на экран
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write(array[i] + "," + " ");
        else System.Console.Write(array[i]);
    }
    System.Console.WriteLine(']');
}

int LengthNewArray(string[] array) // кол-во эл-ов массива, отвечающих условию
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] CreateNewArray(string[] array, string[] result) // заполнение нового массива
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

string[] array = CreateArray();
string[] result = new string[LengthNewArray(array)];
result = CreateNewArray(array, result);
PrintArray(result);