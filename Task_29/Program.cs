// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

using static System.Console;
Clear();

int GetIntFromConsole(string message)
{
    Write(message);
    return int.Parse(ReadLine());
}

int[] FillArray(int Min, int Max)
{
    int[] result = new int[8];
    for (int i = 0; i < 8; i++)
    {
        result[i] = new Random().Next(Min, Max + 1);
    }
    return result;
}

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        if (i == Array.Length - 1)
            Write($"{Array[i]} ");
        else
            Write($"{Array[i]}, ");
    }
}

int message1 = GetIntFromConsole("Enter array's min value = ");
int message2 = GetIntFromConsole("Enter array's max value = ");

int[] Arr = FillArray(message1, message2);
PrintArray(Arr);


