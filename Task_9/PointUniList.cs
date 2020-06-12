using System;
using System.Collections.Generic;
using System.Text;

namespace Task_9
{
    class PointUniList
    {
        // Информационное поле
        public int data;

        // Адресное поле
        public PointUniList next;

        // Конструктор с параметром
        public PointUniList(int N)
        {
            data = N;
            next = null;
        }

        public override string ToString()
        {
            return data + " ";
        }

        // Создание элемента списка
        static PointUniList MakePoint(int N)
        {
            PointUniList p = new PointUniList(N);
            return p;
        }

        // Добавление в начало однонаправленного списка
        public static PointUniList MakeList(int N, PointUniList beg = null)
        {
            // Создаем элемент и добавляем в начало списка
            PointUniList p = MakePoint(N);
            p.next = beg;
            beg = p;

            if (N <= 1)
            {
                return beg;
            }

            return MakeList(--N, beg);
        }

        public static void Print(PointUniList beg)
        {
            // Проверка наличия элементов в списке
            if (beg == null)
            {
                Console.WriteLine("Список пустой");
                return;
            }

            PointUniList p = beg;

            Console.WriteLine("Список:");
            while (p != null)
            {
                Console.WriteLine(p.ToString());
                // Переход к следующему элементу
                p = p.next;
            }
        }

        public static PointUniList DelElement(PointUniList beg, int number, PointUniList p = null, int index = 0)
        {
            if (beg == null)
            {
                Console.WriteLine("Удалять нечего: список пуст");
                return beg;
            }

            if (number == 1)
            {
                beg = beg.next;
                return beg;
            }

            if (p == null)
            {
                if (index == 0)
                {
                    p = beg;
                }
                else
                {
                    return beg;
                }
            }

            if (p.next?.data == number)
            {
                p.next = p.next.next;
                return beg;
            }

            return DelElement(beg, number, p.next, ++index);
        }

        public static int FindElement(PointUniList beg, int findNumber, PointUniList p = null, int index = 0)
        {
            if (beg == null)
            {
                Console.WriteLine("Искать нечего: список пуст");
                return -1;
            }

            if (p == null)
            {
                if (index == 0)
                {
                    p = beg;
                }
                else
                {
                    return -1;
                }
            }

            if (p.data == findNumber)
            {
                return p.data;
            }

            return FindElement(beg, findNumber, p.next, ++index);
        }
    }
}
