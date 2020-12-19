using System;
namespace масчсивы
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] strings = { "это", "быстро", "коричневый", "лис", "прыжки",
 "очень", "это", "ленивый", "пёс", "в", "это",
 "будка" };
            Console.WriteLine("Массив содержит следующие значения:");
            for (int i = strings.GetLowerBound(0); i <= strings.GetUpperBound(0); i++)
                Console.WriteLine(" [{0,2}]: {1}", i, strings[i]);
            String searchString = "это";
            int index = Array.IndexOf(strings, searchString);
            Console.WriteLine("Первое значение \"{0}\" имеет индес {1}.",
            searchString, index);
            index = Array.IndexOf(strings, searchString, 4);
            Console.WriteLine("Первое значение \"{0}\" между индексом 4 и концом
           находится в индексе { 1}.",
        searchString, index);
            int position = index + 1;
            index = Array.IndexOf(strings, searchString, position,
           strings.GetUpperBound(0) - position + 1);
            Console.WriteLine("Первое значение \"{0}\" между индексом {1} и индексом {2}
           находится в индексе { 3}
            ",
        searchString, position, strings.GetUpperBound(0), index);
        }
    }