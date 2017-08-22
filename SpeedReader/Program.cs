using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SpeedReader
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\SpeedReader\DrivingRecord.txt"))
            {
                List<string> list = new List<string>();
                List<int> mathNums = new List<int>();
                List<int> totals = new List<int>();
                List<int> difs = new List<int>();
                List<double> miles = new List<double>();
                List<string> names = new List<string>();
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line);
                    string[] words = line.Split(' ');
                    foreach (string word in words)
                    {
                        
                        if (word.Contains(':'))
                        {
                            string[] numbers = word.Split(':');
                            foreach (string number in numbers)
                            {
                                int mathNum = int.Parse(number);
                                mathNums.Add(mathNum);
                            }
                        }
                        else if(word.Contains('.'))
                        {
                            double distance = double.Parse(word);
                            miles.Add(distance);
                        }
                        else
                        {
                            names.Add(word);

                        }
                    }

                }
                for (int i = 0; i < mathNums.Count - 1; i += 2)
                {
                    int product = mathNums[i] * 60;
                    mathNums[i] = product;

                }
                for (int i = 0; i < mathNums.Count - 1; i += 2)
                {
                    int sum = mathNums[i] + mathNums[i + 1];
                    totals.Add(sum);
                }
                for (int i = 0; i < totals.Count - 1; i += 2)
                {
                    int dif = totals[i + 1] - totals[i];
                    difs.Add(dif);
                }
                foreach (int dif in difs)
                {
                    Console.WriteLine(dif);
                }
            }
        }
    }
}


