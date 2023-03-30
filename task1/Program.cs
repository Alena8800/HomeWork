void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите строку №{0}:    ", i + 1);
        array[i] = Console.ReadLine();
    }
}


void PrintArray(string[] array)
{
    Console.Write("Массив заданный пользователем -> [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine(" ]");
}



void ModifiedArray(string[] arraynew, string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arraynew[count] = array[i];
            count++;
        }
    }
}



void PrintArrayModified(string[] arraynew)
{
    Console.Write(" Новый массив до 3х символов -> [");
    for (int i = 0; i < arraynew.Length; i++)
    {
        Console.Write($"{arraynew[i]}  ");
    }

    Console.Write(" ]");
}

Console.WriteLine("Введите длинну массива строк");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
string[] arraynew = new string[array.Length];
FillArray(array);
PrintArray(array);
ModifiedArray(arraynew, array);
PrintArrayModified(arraynew);