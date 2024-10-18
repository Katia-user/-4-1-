using System;

class Program
{
    static void Main()
    {
        int[] array = new int[10]; 
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, 21);
        }

        Console.WriteLine("Вихідний масив:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        int product = 1;  
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0 && array[i] <= 9)
            {
                product *= array[i];
            }
        }
        Console.WriteLine("Добуток одноцифрових елементів: " + product);
    }
}