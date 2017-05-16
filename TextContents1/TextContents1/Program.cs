using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextContents1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Users\user\Documents\Visual Studio 2017\Projects\FileRead1\ConsoleApp3\test.txt";

            string[] Separators = new string[] { "?", "!", ".", ",", "#", "*", "\"", ":", ";", "-", "<", ">", "?!" };

            SortedList<string, int> ListOfWords = new SortedList<string, int>();
            var symbolcount = new List<SymbolCount>();

            int count = -1;


            int words_count = 1;
            string pages_count = "";

            try
            {
                //Console.WriteLine();
                //Console.WriteLine("**************");
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        foreach (string separators in Separators)
                            line = line.Replace(separators, " ");

                        line = line.Trim();
                        line = line.Replace("  ", " ");

                        //Console.WriteLine(line);

                        //Console.WriteLine();
                        //Console.WriteLine("**************");

                        string[] words = line.Split(new char[] { ' ' });

                        foreach (string s in words)
                        {
                            if (!ListOfWords.ContainsKey(s))
                            {
                                ++count;
                                ListOfWords.Add(s, count);
                                symbolcount.Add(new SymbolCount( 1, "1" ));
                            }
                            else
                            {
                                symbolcount[ListOfWords[s]].Counts = ++symbolcount[ListOfWords[s]].Counts;
                            }
                            //Console.WriteLine(s);
                        }
                    }
                }

                // Коллекция ключей
                ICollection<string> keys = ListOfWords.Keys;

                //foreach (string ss in keys) Console.WriteLine("{0}, {1}", ss, ListOfWords[ss]);

                foreach (string ss in keys)
                {
                    Console.WriteLine("{0}, {1}, {2}" , ss, symbolcount[ListOfWords[ss]].Counts, symbolcount[ListOfWords[ss]].Pages );

                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

    }
}

