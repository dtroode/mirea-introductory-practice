using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Union
{
    [CsvExporter]
    public class Benchmark
    {
        // инициализация двух пустых массивов
        List<int> s1 = new List<int>();
        List<int> s2 = new List<int>();

        // настройки для заполнения массивов
        // 10 миллионов элементов
        int size = 10000000;
        // обрезка массивов до разных количеств элементов
        [Params(1000, 10000, 100000, 1000000, 10000000)]
        public int range;
        // максимальное значение числа в массиве
        int maxValue = int.MaxValue;

        // конструктор, в котором при помощи Random
        // заполняются два массива
        public Benchmark()
        {
            Random rand = new Random();
            s1.Clear();
            s2.Clear();
            for (int i = 0; i < size; i++)
            {
                int firstArray = rand.Next(maxValue);
                int secondArray = rand.Next(maxValue);
                s1.Add(firstArray);
                s2.Add(secondArray);
            }
        }

        // создание экземпляра класса,
        // хранящего метод для тестирования
        Union union = new Union();

        // вспомогательный метод для тестирования
        [Benchmark(Description = "Unite")]
        public void Run()
        {
            List<int> set1 = s1.GetRange(0, range);
            List<int> set2 = s2.GetRange(0, range);
            List<int> res = union.Unite(set1, set2);
        }
    }
}