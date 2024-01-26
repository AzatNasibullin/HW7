// // Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// Console.Write("Введите значение M: ");
// int m = int.Parse(Console.ReadLine());

// Console.Write("Введите значение N: ");
// int n = int.Parse(Console.ReadLine());

// void PrintNumbers(int m, int n)
//     {
//         if (m <= n)
//         {
//             Console.WriteLine(m);
//             PrintNumbers(m + 1, n);
//         }
//     }

// PrintNumbers(m, n);




// // Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int akkerman(int m, int n)
// {
// if (m == 0) return n + 1;
// else if (n == 0) return akkerman(m - 1, 1);
// else return akkerman(m - 1, akkerman(m, n - 1));
// }

// Console.Write($"Функция Аккермана равно {akkerman(m, n)} ");



// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
Console.WriteLine("Введите длину массива ");
int sizeArray= Convert.ToInt32(Console.ReadLine());

int [] randomArray = new int[sizeArray];

void GetArray()
{
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(3,10);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]+ " ");
    }  
}

void PrintArrayInReverse(int[] arr, int index)
    {
        if (index < arr.Length)
        {
            PrintArrayInReverse(arr, index + 1);
            Console.Write(arr[index] + " ");
        }
    }


// GetArray();
// PrintArray(randomArray);
// Console.WriteLine();
// PrintArrayInReverse(randomArray, 0);