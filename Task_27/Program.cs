// Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11     82 -> 10    9012 -> 12

using static System.Console;
Clear();

int GetIntFromConsole(string message)	
{
    Write(message);
    return int.Parse(ReadLine());
}

int SummNumbers(int A)	
{
    int count = 0;
    while(A>0)
    {
        count += A%10;
        A/=10;
    }  
    return count;
}
int A = GetIntFromConsole("Enter A = ");
int count = SummNumbers(A);
WriteLine(count);
