using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            _Dictionary dictionary = new _Dictionary();
            dictionary.Add("5");
            dictionary.Add("a66aa");
            dictionary.Add("aaa77");
            dictionary.Add("a22aa");
            dictionary.Add("aa234a");
            dictionary.Add("aaa332");
            dictionary.Add("aa987676a");
            dictionary.Add("aa987676a");
            dictionary.Add("aa98787897676a");
            dictionary.Add("aa987q3425352676a");



            int index = dictionary["aa98787897676a"];
            Console.WriteLine(index);
            Console.ReadKey();


        }
    }

}
