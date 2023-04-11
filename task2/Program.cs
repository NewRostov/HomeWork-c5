//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19 
//[-4, -6, 89, 6] -> 0

internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        int summ = 0;
        Console.Write("Введите длину массива: ");
        int arrayLenght = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[arrayLenght];
        for (int i = 0; i < arrayLenght; i++)
        {
            array[i] = rnd.Next(-999, 999);

            Console.Write(array[i] + ", ");

            if (i % 2 != 0)
            {
                summ = summ + array[i];
            }

        }
        Console.WriteLine();
        Console.Write("Сумма элементов, стоящих на нечётных позициях: " + summ);
    }
}
