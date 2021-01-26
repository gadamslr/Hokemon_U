using System;

namespace Hokemon_U
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring members
            Hinstinct[] ChallengerArray = new Hinstinct[3];
            Battle_Arena firstArena = new Battle_Arena(); // INSTANTIATED Battle_Arena

            Random rnd = new Random(); // Instantiating the rnd object

            bool repeatGame = true;
            string result;

            Console.WriteLine("Hello to Hokeworld!");

            /*

            Hokemon hokeObject01 = new Hokemon(); // INSTANTIATION of object hokeObject01

            Console.WriteLine("Hokemon name is: {0}", hokeObject01.Name);

            hokeObject01.get_details();

            Hokemon hoke02 = new Hokemon();  // INSTANTIATION of object 2

            Console.WriteLine("Hokemon name is: {0}", hokeObject01.Name);

            Console.WriteLine("Name of Hokemon: {0}",hoke02.Name);
            Console.WriteLine("***********");
            Console.WriteLine("****Details below***");
            hoke02.get_details();

            Hokemon hoke03 = new Hokemon();  // INSTANTIATION of object 2

            Console.WriteLine("Hokemon name is: {0}", hokeObject01.Name);

            hoke03.get_details();

            // Using the about method 
            hokeObject01.about();
            hoke02.about();

*/
/*
            Hokemon hoke04 = new Hokemon();  // INSTANTIATION from Hokemon Class
            hoke04.get_details();
*/

            // Creating PLAYER Hokemon
            Halor playerHokemon01 = new Halor();  // INSTANTIATION from Halor Class
            playerHokemon01.get_details();


            // NPC Hokemon

            for (int i = 0; i < ChallengerArray.Length; i++)
            {
                ChallengerArray[i] = new Hinstinct(); // INSTANTIATING Challenger Hokemon
            }

            while (repeatGame == true)
            {


            
                // Demonstrating POLYMORPHISM with about method
                // a Hokemon instance hoke04
                // a halor instance haloHokemon01
                playerHokemon01.about();

                firstArena.ChallengeMe(playerHokemon01);



                firstArena.Battle(playerHokemon01, ChallengerArray[rnd.Next(0,ChallengerArray.Length)]); // Passing two objects into 

                // the firstArena

                Console.WriteLine("Do you want to repeat the game? (y/n)");
                result = Console.ReadLine();
                if (result.ToLower()[0] == 'n')
                {
                    repeatGame = false;
                }
            }
        }
    }
}
