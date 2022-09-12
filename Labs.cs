using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set
{
    internal class Labs
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Создаем множества.
            var setA = new Set<int>()
            {
                1, 2, 3, 4, 5, 6
            };

            var setB = new Set<int>()
            {
                4, 5, 6, 7, 8, 9
            };

            var setC = new Set<int>()
            {
                2, 3, 4
            };
            var unionpart = Set<int>.Union(setA, setB);
            var union = Set<int>.Union(setC, unionpart);

            // Выводим исходные множества на консоль.
            PrintSet(setA, "Первое множество: ");
            PrintSet(setB, "Второе множество: ");
            PrintSet(setC, "Третье множество: ");

            // Выводим результирующее множество на консоль.
            PrintSet(union, "A U B U C: ");

            Console.ReadLine();
        }

        private static void PrintSet(Set<int> set, string title)
        {
            Console.Write(title);
            foreach (var item in set)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
