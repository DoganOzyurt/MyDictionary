using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> score = new List<int>();
            score.Add(100);
            score.Add(95);
            score.Add(85);
            score.Add(120);


            Console.WriteLine(score.Count);

            MyList<string> clubname = new MyList<string>();
            clubname.Add("Galatasaray");
            clubname.Add("FenerBahce");
            clubname.Add("Besiktas");
            clubname.Add("BartinSpor");

            Console.WriteLine(clubname.Count);


        }
    }
}
