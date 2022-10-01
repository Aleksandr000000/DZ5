// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void FillArray (int [] arr) /// Метод заполнения массива случайными числами 
{
    for (int i= 0; i < arr.Length; i++ )
    {
    arr[i] = new Random().Next(100,1000); 
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

int GetSummChet (int[] arr) // Метод подсчета четных чисел

{
     int count =0;
     for (int i= 0; i < arr.Length; i++ )
     {
        if (arr[i] % 2 == 0)
            count ++;
     }       
     return count;
     
} 


int[] massiv = new int [4];
FillArray(massiv);
PrintArray(massiv);
Console.WriteLine("количество четных чисел в массиве: " + GetSummChet(massiv));