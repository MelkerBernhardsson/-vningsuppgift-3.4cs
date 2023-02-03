using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många poäng fick du på provet?");
            int poäng = int.Parse(Console.ReadLine());
            
            if(poäng < 18)
            {
                Console.WriteLine("du fick ett F");
            }
            else if(poäng < 27)
            {
                Console.WriteLine("du fick betyget E");
            }
            else if(poäng < 35)
            {
                Console.WriteLine("du fick D i betyg");
            }
            else if(poäng < 46)
            {
                Console.WriteLine("du fick ett C");
            }
            else if(poäng < 55)
            {
                Console.WriteLine("du fick betyget B");  
            }
            else
            {
                Console.WriteLine("du fick ett A grattis");
            }
        }
    }
}
