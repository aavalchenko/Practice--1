using System;
using System.IO;

namespace Practice_1
{
    public class Program
    {
        private static int count;
        private static int[] stack;
        private static int[,] newStack;
        public static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Replace("  ", " ").Split(' ');
            count = int.Parse(input[0]);
            stack = new int[count];

            for (int i = 0; i < count; i++)
            {
                stack[i] = int.Parse(input[i + 1]);
            }

            int firstStep = int.Parse(input[input.Length - 1]);
            newStack = new int[firstStep + 1, count + 1];

            File.AppendAllText("output.txt", f(firstStep, 0).ToString());
        }
        private static int s(int i)
        {
            return i >= count ? 0 : stack[i] + s(i + 1);
        }

        private static int f(int k, int i)
        {
            if (newStack[k, i] == 0)
            {
                newStack[k, i] = l(Math.Min(k, count - i), 0, i);
            }

            return newStack[k, i];
        }

        private static int l(int j, int r, int i)
        {
            return j <= 0 ? r : l(j - 1, Math.Max(r, s(i) - f(j, i + j)), i);
        }
    }
}