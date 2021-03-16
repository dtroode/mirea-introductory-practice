using System;
using System.Collections.Generic;
using System.Linq;

namespace union_on_massive
{
  class Test
  {
    public void Testing()
    {
      Union union = new Union();

      // множество идёт раньше #1
      List<double> t1s1 = new List<double>() { 0, 3, 4.5, 8, 10 };
      List<double> t1s2 = new List<double>() { 1, 2, 3, 5.2, 6 };
      List<double> t1r = new List<double>() { 0, 1, 2, 3, 4.5, 5.2, 6, 8, 10 };
      List<double>[] t1 = { t1s1, t1s2, t1r };

      // множество идёт позже #2
      List<double> t2s1 = new List<double>() { 2, 3, 4, 8.6, 10 };
      List<double> t2s2 = new List<double>() { 1, 2, 3.1, 4, 5, 6 };
      List<double> t2r = new List<double>() { 1, 2, 3, 3.1, 4, 5, 6, 8.6, 10 };
      List<double>[] t2 = { t2s1, t2s2, t2r };

      // множество внутри другого #3
      List<double> t3s1 = new List<double>() { 1, 2, 4 };
      List<double> t3s2 = new List<double>() { 1, 2, 3.1, 4, 5, 6 };
      List<double> t3r = new List<double>() { 1, 2, 3.1, 4, 5, 6 };
      List<double>[] t3 = { t3s1, t3s2, t3r };

      // другое множество внутри #4
      List<double> t4s1 = new List<double>() { 1, 2, 3.1, 4, 5, 6 };
      List<double> t4s2 = new List<double>() { 1, 2, 4 };
      List<double> t4r = new List<double>() { 1, 2, 3.1, 4, 5, 6 };
      List<double>[] t4 = { t4s1, t4s2, t4r };

      // множество левее #5
      List<double> t5s1 = new List<double>() { 1, 2, 3.1, 4, 5, 6 };
      List<double> t5s2 = new List<double>() { 8, 10.4, 12, 14.6 };
      List<double> t5r = new List<double>() { 1, 2, 3.1, 4, 5, 6, 8, 10.4, 12, 14.6 };
      List<double>[] t5 = { t5s1, t5s2, t5r };

      // множество правее #6
      List<double> t6s1 = new List<double>() { 8, 10.4, 11.8, 14.6, 18 };
      List<double> t6s2 = new List<double>() { 1, 2, 3.1, 4, 5, 6 };
      List<double> t6r = new List<double>() { 1, 2, 3.1, 4, 5, 6, 8, 10.4, 11.8, 14.6, 18 };
      List<double>[] t6 = { t6s1, t6s2, t6r };

      // множество по краям #7
      List<double> t7s1 = new List<double>() { 1, 2.4, 3.33, 3, 18, 19.5, 222 };
      List<double> t7s2 = new List<double>() { 4, 5.2, 6 };
      List<double> t7r = new List<double>() { 1, 2.4, 3.33, 3, 4, 5.2, 6, 18, 19.5, 222 };
      List<double>[] t7 = { t7s1, t7s2, t7r };

      // множество внутри (не пересекается) #8
      List<double> t8s1 = new List<double>() { 4, 5.2, 6 };
      List<double> t8s2 = new List<double>() { 1, 2.4, 3.33, 3, 18, 19.5, 222 };
      List<double> t8r = new List<double>() { 1, 2.4, 3.33, 3, 4, 5.2, 6, 18, 19.5, 222 };
      List<double>[] t8 = { t8s1, t8s2, t8r };

      // все тесты
      List<double>[][] tests = { t1, t2, t3, t4, t5, t6, t7, t8 };

      for (int i = 0; i < tests.Count(); i++)
      {
        if (Enumerable.SequenceEqual(union.Unite(tests[i][0], tests[i][1]), tests[i][2]))
        {
          Console.WriteLine("✓ Test Passed");
        }
        else
        {
          Console.WriteLine($"× Error in test #{i+1}");
        }
      }
    }
  }
}