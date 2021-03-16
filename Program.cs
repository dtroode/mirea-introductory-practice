using System;
using System.Collections.Generic;

namespace union_on_massive
{
  class Program
  {
    static void Main(string[] args)
    {
      List<double> s1 = new List<double>() {0, 3, 4, 8, 10};
      List<double> s2 = new List<double>() {1, 2, 3, 4, 5, 6};
      
      List<double> res = Union(s1, s2);
      int len = res.Count;
      for (int i = 0; i < len; i++)
      {
        Console.WriteLine(res[i]);
      }
    }

    public static List<double> Union(List<double> set1,
    List<double> set2)
    {
      List<double> union = new List<double>();

      while (set1.Count != 0 || set2.Count != 0)
      {
        if (set1.Count == 0)
        {
          union.AddRange(set2);
          break;
        }
        
        if (set2.Count == 0)
        {
          union.AddRange(set1);
          break;
        }

        if (set1[0] < set2[0])
        {
          union.Add(set1[0]);
          set1.RemoveAt(0);
        }
        else if (set1[0] > set2[0])
        {
          union.Add(set2[0]);
          set2.RemoveAt(0);
        }
        else
        {
          union.Add(set1[0]);
          set1.RemoveAt(0);
          set2.RemoveAt(0);
        }
      }

      return union;
    }
  }
}
