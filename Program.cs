using System;

namespace Hello_c_sharp
{
    class Hello
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hello Who are you?");
            string User = Console.ReadLine();
            Console.WriteLine("Hello " + User + " How are you ?");
            String Mood = Console.ReadLine();
            if (Mood == "good")
            {
                Console.WriteLine("I feel " + Mood + " as well " + User);
            }
            else
            {
                Console.WriteLine("Ohhh sorry to hear that, " + User);
            }
        
        }
    }
}
