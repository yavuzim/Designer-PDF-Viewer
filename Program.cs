using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace ConsoleApp1
{
    class Program
    {
        public static int designerPdfViewer(List<int> h, string word)
        {
            List<int> deger = new List<int>();
            char[] harfler = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < h.Count; i++)
            {
                for (int j = 0; j < harfler.Length; j++)
                {
                    if (word[i] == harfler[j])
                    {
                        deger.Add(h[j]);
                    }
                }
                if (i + 1 == word.Length) break;
            }
            int enbuyuk = deger.Max();
            return enbuyuk * word.Length;
        }
        static void Main(string[] args)
        {
            List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();

            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);
            Console.WriteLine("\n\nThe selection area for this word is : " + result + " mm^2");
            Console.ReadLine();
        }
    }
}
