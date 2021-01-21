using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon_U
{
    class Halor : Hokemon // INHERITING from parent Hokemon class
    {
        private string team = "Halor";

        public void about()
        {
            Console.WriteLine("I am {0} part of the team, {1}!!",Name, team);
        }
    }
}
