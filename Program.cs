using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class MainClass
{
    public static void Main()
    {
        //int countOfVariations = 0;
        string input = File.ReadAllText("input.txt").Trim();
        List<string> rem = new();

        while (input.Distinct().Count() > 1)
        {
            const int z = (int)'0';
            const int n = (int)'9';
            List<int> variation = new();

            for (int i = z; i <= n; ++i)
            {
                string temp = "";
                foreach (char a in input)    if (a != (char)i)    temp += a;
                if (temp != input) variation.Add(Convert.ToInt32(temp));
            }
            int max = -1;
            foreach (int var in variation)    if (var > max)    max = var;
            rem.Add(Convert.ToString(max));
            input = Convert.ToString(max);
        }
        string onOutput = "";
        onOutput += rem.Count;
        foreach (string str in rem)
        {
            onOutput += '\n';
            onOutput += str;
        }
        File.WriteAllText("output.txt", onOutput);
    }
}