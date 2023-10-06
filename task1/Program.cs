string[] Main(string array1)
{
    string[] array = new string[5];
    {
        Console.WriteLine("ВИДИТЕ ТЕКСТ");

        for (int i = 0; i < array.Length; i++)
        {

            array[i] = Console.ReadLine();

        }
    }

    return array;
}
string[] Void(string array2)
{
    string[] array = new string[5];

    return array;

}
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
void PrintArray(string[] array2)
{
    Console.WriteLine("Второй массив ");

    for (int i = 0; i < array2.Length; i++)

    {
        Console.Write($"{array2[i]} ");
    }
    Console.WriteLine();
}

string[] array1 = Main(String.Empty);
string[] array2 = Void(String.Empty);
SecondArrayWithIF(array1, array2);
PrintArray(array2);
