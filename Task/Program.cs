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