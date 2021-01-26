using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon_U
{
    class Hinstinct : Hokemon
    {
        public Hinstinct()
        {
            Team = "Halor";
        }

        public void about()
        {
            Console.WriteLine("I am {0} part of the team, {1}!!", Name, Team);
        }
    }
}
