//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
//и минимальным элементов массива.
//[3 7 22 2 78] -> 76

internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        Console.Write("Введите длину массива: ");
        int arrayLenght = Convert.ToInt32(Console.ReadLine());
        int imax = 0;
        int imin = 0;

        int[] array = new int[arrayLenght];
        for (int i = 0; i < arrayLenght; i++)
        {
            array[i] = rnd.Next(-99999, 99999);
            if (array[i] > array[imax])
            {
                imax = i;
            }

            if (array[i] < array[imin])
            {
                imin = i;
            }

            Console.WriteLine(i + "-й элемент: " + array[i] + ", ");

        }
        Console.WriteLine("максимальное число = " + array[imax]);
        Console.WriteLine("минимальное число = " + array[imin]);
        Console.WriteLine("разница между максимальным и минимальным элементов массива = " + (array[imax] - array[imin]));

    }
}
