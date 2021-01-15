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

            hoke02.get_details();

            Hokemon hoke03 = new Hokemon();  // INSTANTIATION of object 2

            //Console.WriteLine("Hokemon name is: {0}", hokeObject01.Name);

            hoke03.get_details();

        }
    }
}
