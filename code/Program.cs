// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исколючительно массивами.

string[] ReadStringArray(int start)
{
    int count = start;
    string[] first = new string[count];
    bool stop = false;

    while (stop != true)
    {
        Console.Write("Введите данные (если хотите закончить ввод, то введите слово FINISH): ");
        string text = Console.ReadLine();

        if (text.ToLower() == "finish")
        {
            stop = true;
        }

        else if (text == "")
        {
            Console.Write("Повторите ввод. ");
        }

        else
        {
            count++;
            string[] second = new string[count];

            for (int i = 0; i < second.Length - 1; i++)
            {
                second[i] = first[i];
            }

            second[count - 1] = text;
            first = second;
        }
    }

    // PrintArray(first); // проверяем корректность работы метода
    // Console.WriteLine(); // пустая строка для красоты
    return first;
}

void PrintArray(string[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + "; ");
    }
    
    int finish = array.Length - 1;
    Console.WriteLine($"{array[finish]}]");
}

int HowMuch(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) count++;
    }

    // Console.WriteLine($"count = {count}"); // проверили корректность работы метода
    return count;
}

string[] GetThree(string[] array, int size)
{
    string[] arrNew = new string[size];
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            arrNew[index] = array[i];
            index++;
        }
    }

    return arrNew;
}

string[] arrDad = ReadStringArray(0);
int newSize = HowMuch(arrDad);

if (newSize == 0) Console.WriteLine("В массиве нет строк, длина которых меньше 4 символов.");

else
{
    string[] arrSon = GetThree(arrDad, newSize);
    PrintArray(arrSon);
}