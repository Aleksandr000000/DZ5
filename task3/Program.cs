// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


void FillArray (double [] arr) /// Метод заполнения массива случайными числами 
{
    for (int i= 0; i < arr.Length; i++ )
    {
    arr[i] = new Random().NextDouble(); 
    }
}

void PrintArray(double[] arr) // Метод вывода массива на экран 

{
    Console.WriteLine("Дан массив заполненный вещественными чмслами: ");
     for (int i= 0; i < arr.Length; i++ )
     {
        Console.Write(arr[i] + " ");
     }
     Console.WriteLine();
}



void MaxMinDigit(double[] arr) // метод поиска Макс и Мин
{
double max = arr[0];
double min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        // ищем макс
        max = arr[i];
    }
    if (arr[i] < min)
    {
      // ищем мин
      min = arr[i];
    }

}
Console.WriteLine(max+ " - максимальный элемент массива");
Console.WriteLine(min+ " - минимальный элемент массива");
Console.WriteLine("Итого " + max+ " - " + min + " = " + (max-min));

}


double[] massiv = new double [5];
FillArray(massiv);
PrintArray(massiv);
MaxMinDigit(massiv);