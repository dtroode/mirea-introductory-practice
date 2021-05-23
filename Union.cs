using System.Collections.Generic;

namespace Union
{
    class Union
    {
        public List<int> Unite(List<int> set1, List<int> set2)
        {
            // создание массива, склеенного из двух входных
            List<int> joined = new List<int>(set1);
            joined.AddRange(set2);

            // общая длина массивов
            int length = joined.Count;

            // словарь для проверки элемента на вхождение
            // и пустой итоговый массив
            Dictionary<int, bool> isUsed = new Dictionary<int, bool>(length);
            List<int> union = new List<int>();

            // заполнение словаря
            for (int i = 0; i < length; i++) isUsed[joined[i]] = false;

            // проверка каждого элемента на вхождение
            for (int i = 0; i < length; i++)
            {
                if (isUsed[joined[i]] == false)
                {
                    union.Add(joined[i]);
                    isUsed[joined[i]] = true;
                }
            }

            return union;
        }
    }
}