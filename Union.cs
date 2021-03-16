using System.Collections.Generic;

namespace union_on_massive
{
  class Union
  {
    public List<double> Unite(List<double> set1,
    List<double> set2)
    {
      List<double> union = new List<double>();

      while (set1.Count != 0 || set2.Count != 0)
      {
        if (set1.Count == 0)
        {
          union.AddRange(set2);
          set2.Clear();
          break;
        }

        if (set2.Count == 0)
        {
          union.AddRange(set1);
          set1.Clear();
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