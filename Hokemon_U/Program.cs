using System;

namespace Hokemon_U
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to Hokeworld!");

            Hokemon hokeObject01 = new Hokemon();

            //Console.WriteLine("Hokemon name is: {0}", hokeObject01.Name);

            hokeObject01.get_details();

            Hokemon hoke02 = new Hokemon();

            //Console.WriteLine("Hokemon name is: {0}", hokeObject01.Name);

            hoke02.get_details();



        }
    }
}
