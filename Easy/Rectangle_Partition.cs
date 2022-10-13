using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int w = int.Parse(inputs[0]);
        int h = int.Parse(inputs[1]);
        int countX = int.Parse(inputs[2]);
        int countY = int.Parse(inputs[3]);

        List<int> xLengths = new List<int>();
        xLengths.Add(w);
        inputs = Console.ReadLine().Split(' ');
        for (int i = 0; i < countX; i++)
        {
            int x = int.Parse(inputs[i]);
            xLengths.Add(x);
        }
        xLengths.Sort((a, b) => b.CompareTo(a));

        List<int> xDiff = new List<int>();
        for (int i = 1; i < xLengths.Count; i++)
        {
            for (int j = 0; j < i; j++)
            {
                xDiff.Add(xLengths[j] - xLengths[i]);
            }
        }
        xLengths = xLengths.Concat(xDiff).ToList();
        xLengths.Sort();

        Dictionary<int, int> w_dict = new Dictionary<int, int>();
        for (int i = 0; i < xLengths.Count; i++)
        {
            if (!w_dict.ContainsKey(xLengths[i]))
            {
                w_dict.Add(xLengths[i], 1);
            }
            else 
            {
                w_dict[xLengths[i]] += 1;
            }
        }

        List<int> yLengths = new List<int>();
        yLengths.Add(h);
        inputs = Console.ReadLine().Split(' ');
        for (int i = 0; i < countY; i++)
        {
            int y = int.Parse(inputs[i]);
            yLengths.Add(y);
        }
        yLengths.Sort((a, b) => b.CompareTo(a));

        List<int> yDiff = new List<int>();
        for (int i = 1; i < yLengths.Count; i++)
        {
            for (int j = 0; j < i; j++)
            {
                yDiff.Add(yLengths[j] - yLengths[i]); 
            }
        }
        yLengths = yLengths.Concat(yDiff).ToList();
        yLengths.Sort();

        Dictionary<int, int> h_dict = new Dictionary<int, int>();
        for (int i = 0; i < yLengths.Count; i++)
        {
            if (!h_dict.ContainsKey(yLengths[i]))
            {
                h_dict.Add(yLengths[i], 1);
            }
            else 
            {
                h_dict[yLengths[i]] += 1;
            }
        }

        int result = 0;
        foreach (KeyValuePair<int, int> kvp in w_dict)
        {
            if (h_dict.ContainsKey(kvp.Key))
            {
                result += kvp.Value * h_dict[kvp.Key];
            }
        }
        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(result);
    }
}