using System;
/*Создать массив. Пройти по нему циклом.
Для каждого числа создать строку из этих цифр этой длины.*/
namespace регистр_букв
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов в массииве");
            int size = 0;
            size = Int32.Parse(Console.ReadLine());// для того чтобы ввести число с клавиатуры
            int[] numbers = new int[size];
            int i = 0;
            Console.WriteLine("Введите с какого числа будет начало");
            for (i = Int32.Parse(Console.ReadLine()); i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " " + "\n");
                }
                //Console.WriteLine(i);
            }
           





        }
    }
}
