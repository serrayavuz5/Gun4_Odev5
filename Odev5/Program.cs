using System;

namespace Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("Serra", "Yavuz");
            myDictionary.Add("Engin", "Demiroğ");
            Console.WriteLine(myDictionary.Keys[0] + " " + myDictionary.Values[0]);
            Console.WriteLine(myDictionary.Keys[1] + " " + myDictionary.Values[1]);
        }
    }
}
