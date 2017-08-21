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

                    //Console.WriteLine(line);

                    //take out :
                    string[] words = line.Split(' ');
                    foreach (string word in words)
                    {
                        
                        if(word.Contains(':'))
                        {
                            string[] numbers = word.Split(':');
                            foreach( string number in numbers)
                            {
                                Console.WriteLine(number);
                                //int mathNum = int.Parse(number);
                            }  
                        }
                       // //take out chars
                        //char[] letters =  word.ToCharArray();
                        // foreach( char letter in letters)
                        // {
                        //     bool isNum = Char.IsNumber(letter);
                        //     if(isNum == true)
                        //     {
                        //         Console.WriteLine(letter);
                        //     }
                    }
                    }

                }
                //for (int i = 0; i <= word.Length - 1; i++)
                //{
                //    if (line[i] ==':')
                //    {
                //        line[i].Replace(':', '.');
                //    }

                //    Console.WriteLine(i);
                //}

            }
        }
    }


