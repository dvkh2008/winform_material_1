using System;
using System.Collections.Generic;
using System.Text;

namespace SKCT.Helper
{
    public static class ArrayHelper
    {
        public static List<T> Splice<T>(this List<T> source, int index, int count)
        {
            // Only get remaining - Do not throw exception
            var trueCount = source.Count >= index + count ? count : source.Count - index;
            var items = source.GetRange(index, trueCount);
            source.RemoveRange(index, trueCount);
            return items;
        }

        public static List<int> GetListOfNo(int total)
        {
            var result = new List<int>();
            for (int i = 1; i <= total; i++)
            {
                result.Add(i);
            }
            return result;
        }

        public static List<int> GetPageSize(int total, int pageSize)
        {
            var count = (total / pageSize);
            if (total% pageSize > 0)
            {
                count++;
            }
            return GetListOfNo(count);
        }
    }
}
