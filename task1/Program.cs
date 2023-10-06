//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


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
