//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

int multiply(int a, int b)
    {
    int result=1;
    for(int i=0; i<b; i++) 
    result*=a; 
    return result;
    }

int bingo=multiply(3,3);
Console.WriteLine(bingo);

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void sum ()
{
    int numSum = Convert.ToInt32(Console.ReadLine());
    int result = 0;

    for(int i=1;numSum>0;i++)
    {
        result+=numSum%10;  //плюсуем последнее число
        numSum=numSum/10;   //избавляемся от последнего числа
    }
    Console.WriteLine(result);

}

sum ();


/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

void mass()
{   int x = Convert.ToInt32(Console.ReadLine());
    int [] arr = new int [x];

    for(int i=0;i<x;i++)
    {
        arr [i] = (new Random()).Next(0,11);
        Console.Write(arr [i] + ", ");
    }
}

mass();
