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

    }
}
