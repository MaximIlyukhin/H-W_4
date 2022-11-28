// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

using static System.Console;
Clear();

int GetIntFromConsole(string message)	//получения числа с консоли
{
    Write(message);
    return int.Parse(ReadLine());
}
int RaiseToDegree(int a, int b)     //возведение в степень
{
    if (b == 0)
    {
        return 1;
    }
    int result = a;
    for (int i = 2; i <= b; i++) 
    {                       
        result*=a;
    }
    return result;
}
int message1 = GetIntFromConsole("Enter A = ");
int message2 = GetIntFromConsole("Enter B = ");
int Pow = RaiseToDegree(message1, message2);
Write(Pow);










