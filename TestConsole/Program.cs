using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
			//A test Comment
			var leChangelele = true;
            sw.Start();
            var ff = SplitInParts2("The quick brown fox jumps over the little lazy dog", 11);
            sw.Stop();
            Console.WriteLine(sw.Elapsed +" "+sw.ElapsedMilliseconds +" "+sw.ElapsedTicks +" "+sw.IsRunning);
            Console.ReadKey();
        }

        static IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }

        public static string SplitInParts2(string str, int partLength)
        {
            //comment next ckeck
            System.Collections.Generic.IList<string> list = new System.Collections.Generic.List<string>();
            int stringLength = str.Length;
            string s = string.Empty;
            StringBuilder s1 = new StringBuilder();
            string s2 = string.Empty;
            if (str != null && stringLength > 0 && partLength + 1 > 0)
            {
                for (var index = 0; index < stringLength; index += partLength)
                {
                    s = str.Substring(index, Math.Min(partLength, stringLength - index));
                    if (s.Contains(" "))
                    {
                        s1.Append(s);
                    }
                    else
                    {
                        s1.Append(" ").Append(s);
                    }
                }

                return s1.ToString();
            }
            else
            {
                return str;
            }
        }


        public static string SplitInParts(string str, int partLength)
        {
            System.Collections.Generic.IList<string> list = new System.Collections.Generic.List<string>();
            int stringLength = str.Length;
            if (str != null && stringLength > 0 && partLength > 0)
            {
                for (var index = 0; index < stringLength; index += partLength)
                {
                    list.Add((str.Substring(index, Math.Min(partLength, stringLength - index))).Trim());
                }
                return string.Join(" ", list);
            }
            else
            {
                return str;
            }
        }



        public enum Country
        {
            None = 0,
            [DescriptionAttribute("Australia")]
            AU = 1,
            [DescriptionAttribute("Hong Kong")]
            HK = 2,
            [DescriptionAttribute("India")]
            IN = 3,
            [DescriptionAttribute("New Zealand")]
            NZ = 4,
            [DescriptionAttribute("Singapore")]
            SG = 5,
            [DescriptionAttribute("United Kingdom")]
            UK = 6,
            [DescriptionAttribute("United States of America")]
            US = 7
        }
    }
}
