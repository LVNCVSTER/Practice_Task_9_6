using System;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов списка:");
            int N = InputInt(1, 100);
            PointUniList list = PointUniList.MakeList(N);
            PointUniList.Print(list);
            Console.WriteLine("Введите элемент для удаления:");
            int numForDel = InputInt(1, 100);
            list = PointUniList.DelElement(list, numForDel);
            PointUniList.Print(list);
            Console.WriteLine("Введите элемент для поиска:");
            int numForFind = InputInt(1, 100);
            int element = PointUniList.FindElement(list, numForFind);
            Console.WriteLine(element == -1 ? "Элемент не найден" : "Найденный элемент: " + element);

            Console.ReadLine();
        }
        public static int InputInt(int min, int max)
        {
            int num;

            while (!int.TryParse(Console.ReadLine(), out num) || num < min || num > max)
            {
                if (num < min || num > max)
                {
                    Console.WriteLine($"Введите целое число от {min} до {max}");
                    continue;
                }

                Console.WriteLine("Введите целое число");
            }

            return num;
        }
    }
}
