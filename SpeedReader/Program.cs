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
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line);

                    Console.WriteLine(line);
                }
            }
        }
    }
}
