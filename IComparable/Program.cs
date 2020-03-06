using System;
using System.IO;
using System.Collections.Generic;

namespace IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\alot.txt";

            try
            {
                StreamReader sr = new StreamReader(sourcePath);
                List<string> list = new List<string>();

                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    list.Add(s);                    
                }
                
            }
            catch (IOException e) {
                Console.WriteLine("Um erro ocorreu: " + e.Message);
            }
        }
    }
}
