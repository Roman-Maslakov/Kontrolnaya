string[] MakeArray()
{
    int n = 0;
    string[] arr = new string[n];
    Console.WriteLine("Чтобы добавить слово наберите любой набор символов и нажмите Enter");
    Console.WriteLine("Чтобы прекратить заполнение массива напишите Stop");
    while (true)
    {
        string word = Console.ReadLine()!;
        if (word.ToLower() != "stop")
        {
            if (word != String.Empty)
            {
                Array.Resize(ref arr, n + 1);
                arr[n] = word;
                n++;
            }
            else Console.WriteLine("Напишите слово");
        }
        else break;
    }
    return arr;
}

string PrintArray(string[] array)
{
    string result = String.Join(", ", array);
    return("[" + result + "]");
}

string[] SortArray(string[] arr2)
{
    int k = 0;
    string[] sortedArr = new string[k];
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i].Length < 4) 
        {
            Array.Resize(ref sortedArr, k + 1);
            sortedArr[k] = arr2[i];
            k++;
        }
    }
    return sortedArr;
}