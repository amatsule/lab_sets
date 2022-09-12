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
            var universum = newuniversum(20);
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
            var notB = notset(setB, universum);
            var unionpart = Set<int>.Union(setA, setB);
            var union = Set<int>.Union(setC, unionpart);
            var set1 = Set<int>.Intersection(setC, setA);
            var set2 = Set<int>.Union(set1, notB);

            // Выводим исходные множества на консоль.
            PrintSet(setA, "Первое множество: ");
            PrintSet(setB, "Второе множество: ");
            PrintSet(setC, "Третье множество: ");
            PrintSet(universum, "Универсум: ");
            PrintSet(notB, "Не второе множество: ");

            // Выводим результирующее множество на консоль.
            PrintSet(union, "A U B U C: ");
            PrintSet(set2, "C пересечение A Обьединение с не B ");

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

        private static Set<int> newuniversum(int n)
        {
            var resultSet = new Set<int>();
            for (int i = 1; i <= n; i++)
            {
                resultSet.Add(i);
            }
            return resultSet;
        }

        private static Set<int> notset(Set<int> set, Set<int> universum)
        {
            var resultSet = new Set<int>();
            foreach (int item in universum)
            {
                if (!set.Contains(item))
                {
                    resultSet.Add(item);
                } 
            }

            return resultSet;
        }

    }
}
