
// Домашняя работа № 9

// Задача 1 - Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int num)
{
    Console.Write(num +  " ");
    if(num > 1)  ShowNums(num - 1); 
}
Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNums(num);
*/
// Задача 2 - Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumOfElements(int M, int N)
{
    if(M==N) 
    {
        return N;
    }
    else 
    {
        return M + SumOfElements(M + 1, N);
    }
}
Console.WriteLine(SumOfElements(1,15));
*/
// Задача 3 - Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
/*
int Akkerman (int m, int n)
{
    if(m==0)
    {
    return n + 1;
    }
    else if(m > 0 && n ==0)
    {
       return Akkerman(m - 1,1);
    }
    else 
    return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.WriteLine(Akkerman(3,2));
*/


// Задача 5 (Домашняя работа 8) -  Напишите программу, которая заполнит спирально массив 4 на 4. 
/*
int[,] CreateSpiral()
{
    Console.Write("Input a number of rows: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[n,n];
    int number = 1;
    for(int i = 0; i < n/2; i++)
    {
        for(int j = i; j < n - i; j++)
        {
            array[i, j] = number;
            number++;
            for(int k = i + 1; k < n - i; k++)
            {
                array[k, n - 1 - i] = number;
                for(int m = n - i - 2; m >= i; m--)
                {
                    array[n - 1 - i, m] = number;
                    for(int b = n - 2 - i; b > i; b--)
                    {
                        array[b,i] = number;
                    }
                }
            }

        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] myArray = CreateSpiral();
Show2dArray(myArray);
*/