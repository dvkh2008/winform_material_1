using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SKCT.Helper
{
    public static class DateHelper
    {
        public static (int day, int month, int year) CookDate(string date)
        {
            if (string.IsNullOrWhiteSpace(date))
            {
                return (0, 0, 0);
            }
            try
            {
                if (double.TryParse(date, out double d))
                {
                    var dateTime =DateTime.FromOADate(d);
                    return (dateTime.Day, dateTime.Month, dateTime.Year);
                }
                //else if (DateTime.TryParseExact(date, "dd/MM/yyyy", provider: null, DateTimeStyles.None, out DateTime dateTime))
                //{
                //    return (dateTime.Day, dateTime.Month, dateTime.Year);
                //}
                //else if (DateTime.TryParseExact(date, "dd-MM-yyyy", provider: null, DateTimeStyles.None, out DateTime dateTime2))
                //{
                //    return (dateTime2.Day, dateTime2.Month, dateTime2.Year);
                //}
                else if (date.Contains('/'))
                {
                    var data = date.SplitEx('/').Select(x => int.Parse(x)).ToArray();
                    if (date.Length > 2)
                    {
                        return (data[0], data[1], data[2]);
                    }
                }
                else if (date.Contains('-'))
                {
                    var data = date.SplitEx('-').Select(x => int.Parse(x)).ToArray();
                    if (date.Length > 2)
                    {
                        return (data[0], data[1], data[2]);
                    }
                }
                return (0, 0, 0);
            }
            catch
            {
                return (0, 0, 0);
            }
        }

        private static string[] SplitEx(this string s, char c)
        {
            return s.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0].Split(c, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
