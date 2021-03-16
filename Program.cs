using System;
using System.Collections.Generic;

namespace union_on_massive
{
  class Program
  {
    static void Main(string[] args)
    {
      List<double> s1 = new List<double>() {3, 4, 6, 8, 10};
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

      int len1 = set1.Count;
      int len2 = set2.Count;

      int counter1 = 0;
      int counter2 = 0;

      while (counter1 != len1 || counter2 != len2)
      {
        if (counter1 == len1)
        {
          for (int i = counter2; i < len2; i++)
          {
            union.Add(set2[i]);
          }
          break;
        }
        
        if (counter2 == len1)
        {
          for (int i = counter1; i < len1; i++)
          {
            union.Add(set1[i]);
          }
          break;
        }

        if (set1[counter1] < set2[counter2])
        {
          union.Add(set1[counter1]);
          counter1++;
        }
        else if (set1[counter1] > set2[counter2])
        {
          union.Add(set2[counter2]);
          counter2++;
        }
        else
        {
          union.Add(set2[counter2]);
          counter1++;
          counter2++;
        }
      }

      return union;
    }
  }
}
