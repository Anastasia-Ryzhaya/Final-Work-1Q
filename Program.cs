// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

string[] array = {"hallo", "534", "%", "my name", "@%^&#", "ok", "2", "43526", "like", "--"};

string[] FillArray(string[] arr)
{
    string[] myArray = {};
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            Array.Resize(ref myArray, index + 1);
            myArray[index] = arr[i];
            index++;
        }
    }
    return myArray;
}

void PrintArray(string[] mass)
{
    Console.Write($"[{String.Join(", ", mass)}]");
}

PrintArray(FillArray(array));