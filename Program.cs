/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с 
клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

void FillArray(string[] arrayWord) // вводим элементы массива
{
    Console.WriteLine("Введите элементы массива 1: ");
    for (int i = 0; i < arrayWord.Length; i++)
    {
        Console.Write($"[{i}]");
        arrayWord[i] = Console.ReadLine()!;
    }
}

void PrintArray(string[] ArrayPrnt) // печать элементов массива
{
    Console.Write("[");
    for (int i = 0; i < ArrayPrnt.Length; i++)
    {
        Console.Write(ArrayPrnt[i]);
        if (i != ArrayPrnt.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("] ");
}

string[] SearchStr(string[] findElement) // заполнение массива 2
{
    int count = 0;
    string symbol = String.Empty;
    for (int i = 0; i < findElement.Length; i++)
    {
        symbol = findElement[i];
        if (symbol.Length <= 3)
        {
            count++;
        }
    }
    string[] ArrayResult = new string[count]; // определили длину массива 2

    int result = 0;
    for (int j = 0; j < findElement.Length; j++) // перебор и поиск элементов <=3 символов
    {
        symbol = findElement[j];
        if (symbol.Length <= 3)
        {
            ArrayResult[result] = symbol;
            result++;
        }
    }
    return ArrayResult;
}

//try // определение ошибок ввода

System.Console.Write("Введите размер массива 1:");
int sizeArray = Convert.ToInt32(Console.ReadLine());
string[] arrayStart = new string[sizeArray];

FillArray(arrayStart);

string[] ArrayResult = SearchStr(arrayStart);
PrintArray(arrayStart);

System.Console.Write(" -->(значения <=3 символам)--> ");
Console.ForegroundColor=ConsoleColor.DarkGreen;
PrintArray(ArrayResult);
Console.ResetColor();


