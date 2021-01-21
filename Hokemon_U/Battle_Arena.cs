using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon_U
{
    class Battle_Arena
    {
        public Battle_Arena() // CONSTRUCTOR method runs 1st
        {
            Console.WriteLine("Welcome to the Battle Arena!!!!");

        }

        public void ChallengeMe(Hokemon hokeChallenge)  // Passing a Hoke Object into Method
                                                            //to use in the method
        {
            Console.WriteLine("{0}: says ' I want a BATTLE!!!!!'", hokeChallenge.Name);

        }

        public void ChallengeAccepted(Hokemon Challenger, Hokemon Accepter)
        {
            Console.WriteLine("{0}: 'I accept you challenge for a fight'" +
                "Come on then {1} lets RUMBLE!!",Accepter.Name, Challenger.Name);
        }

        public void Battle(Hokemon Attacker, Hokemon Defender)
        {
            int attackValue;
            int defenceValue;
            int round = 0;

            Hokemon tempHoke;

            while (Attacker.Health >= 0 || Defender.Health >= 0)
            {
                round += 1; // This is the same as round = round + 1

                Console.WriteLine("\n****** ROUND {0} ******\n\n", round);

                // Turn base - Iteratates 2wise so each Hokemon gets an attack
                for (int i = 0; i < 2; i++)
                {

                    attackValue = Attacker.attackCalculator();
                    defenceValue = Defender.defenceCalculator();

                    Console.WriteLine("{0}: Attacks with value: {1}\n", Attacker.Name, attackValue);
                    
                    System.Threading.Thread.Sleep(2000); // Sleep statement for 2s
                    
                    Console.WriteLine("{0}: Generates a defence...", Defender.Name);
                    Console.WriteLine("{0}: Defence value {1}\n", Defender.Name, defenceValue);

                    Console.WriteLine("{0}: Defender Health {1}", Defender.Name, defenceValue);
                    Console.WriteLine("Calculation: (Health {0} + Defence {1}) - AttackValue {2}", Defender.Health, defenceValue, attackValue);
                    Defender.Health = (Defender.Health + defenceValue) - attackValue;
                

                    Console.WriteLine("{0}: Defender New Health {1}", Defender.Name, Defender.Health);

                    //Example of how OBJECTS can be switched identifier names
                    // This saves having to repeat code

                    Console.WriteLine("\n***Switch turns: Defender becomes the Attacker ***\n");

                    tempHoke = Attacker;
                    Attacker = Defender;
                    Defender = tempHoke;

                }

            }

            if (Attacker.Health > Defender.Health)
            {
                Console.WriteLine("{0} WINS the BATTLE!!", Attacker.Name);
            }
            else
            {
                Console.WriteLine("{0} WINS the BATTLE!!", Defender.Name);
            }

        }
    }
}
