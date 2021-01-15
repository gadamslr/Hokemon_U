using System;

namespace Hokemon_U
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to Hokeworld!");

            Hokemon hokeObject01 = new Hokemon(); // INSTANTIATION of object hokeObject01

            //Console.WriteLine("Hokemon name is: {0}", hokeObject01.Name);

            hokeObject01.get_details();

            Hokemon hoke02 = new Hokemon();  // INSTANTIATION of object 2

            //Console.WriteLine("Hokemon name is: {0}", hokeObject01.Name);

            Console.WriteLine("Name of Hokemon: {0}",hoke02.Name);
            Console.WriteLine("***********");
            Console.WriteLine("****Details below***");
            hoke02.get_details();

            Hokemon hoke03 = new Hokemon();  // INSTANTIATION of object 2

            //Console.WriteLine("Hokemon name is: {0}", hokeObject01.Name);

            hoke03.get_details();

            Battle_Arena firstArena = new Battle_Arena(); // INSTANTIATED Battle_Arena

            firstArena.ChallengeMe(hokeObject01);

            firstArena.ChallengeAccepted(hokeObject01, hoke03); // Passing two objects into 
                                                                // the firstArena

        }
    }
}
