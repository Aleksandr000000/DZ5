// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void FillArray (int [] arr) /// Метод заполнения массива случайными числами 
{
    for (int i= 0; i < arr.Length; i++ )
    {
    arr[i] = new Random().Next(-99,100); 
    }
}

void PrintArray(int[] arr) // Метод вывода массива на экран 

{
    Console.WriteLine("Дан массив: ");
     for (int i= 0; i < arr.Length; i++ )
     {
        Console.Write(arr[i]+ " ");
     }
     Console.WriteLine();
}

int GetSummNeChetPosition (int[] arr) // Метод подсчета четных чисел
{
     int summ =0;
     for (int i= 0; i < arr.Length; i++ )
     {
        if (i % 2 == 1 )
            summ +=  arr[i];
     }       
     return summ;
     
} 

int[] massiv = new int [6];
FillArray(massiv);
PrintArray(massiv);
Console.WriteLine("Сумма чисел стоящих на нечетных позициях массива составляет: " + GetSummNeChetPosition(massiv));