using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Homework_BePositive
{
    class BePositive16
    {
        static void Main(string[] args)
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                var numbers = new List<int>();

                for (int k = 0; k < input.Length; k++)
                {
                    if (!input[k].Equals(string.Empty))
                    {
                        int num = int.Parse(input[k]);
                        numbers.Add(num);
                    }
                }

                bool found = false;
                
                for (int k = 0; k < numbers.Count; k++)
                {
                    int curNum = numbers[k];

                    if (curNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(curNum);

                        found = true;
                    }
                    else
                    {
                        if (k < numbers.Count - 1)
                        {
                            curNum += numbers[k + 1];
                            k++;
                        }

                        if (curNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(curNum);

                            found = true;
                        }
                    }
                    if (k == numbers.Count - 1 && found == true)
                    {
                        Console.WriteLine();
                    }
                }

                if (!found)
                {
                    Console.WriteLine("(empty)");
                }
            }
        }
    }
}
