//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        int c = 0;
        Console.Write("Введите длину массива: ");
        int arrayLenght = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[arrayLenght];
        for (int i = 0; i < arrayLenght; i++)
        {
            array[i] = rnd.Next(100, 999);

            Console.Write(array[i] + ", ");

            if (array[i] % 2 == 0)
            {
                c++;
            }

        }
        Console.WriteLine();
        Console.Write("Количество чётных чисел в массиве: " + c);
    }
}