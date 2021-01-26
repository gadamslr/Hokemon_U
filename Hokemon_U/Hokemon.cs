using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon_U
{
    class Hokemon
    {

        // MEMBERS of a CLASS include Attributes, Properties and Methods

        // Attributes
        private string name;
        private int health;
        private int max_health;
        private int attack;
        private int speed;
        private int defense;
        private string team = "Hokemon";

        // Properties

        public string Name
        {
            get { return name; }   // access to the name attribute
            set { name = value; }  // sets the name attribute
        }
        public int Health
        {
            get { return health; }   // access to the health attribute
            set { health = value; }
        }

        public string Team
        {
            get { return team; }   // access to the name attribute
            set { team = value; }  // sets the name attribute
        }
        // Methods

        public Hokemon()  // CONSTRUCTOR method runs 1st when INSTANTIATED
        {
            provide_name();
            max_health = 100;
            health = random_int_generator(10, max_health);
            attack = random_int_generator(10, 100);
            speed = random_int_generator(10, 100);
            defense = random_int_generator(10, 100);
        }

        public void provide_name() // METHOD
        {
            Console.WriteLine("Enter a name for your Hokemon: ");
            name = Console.ReadLine();
        }

        public void get_details()
        {
            Console.WriteLine("\n\n*********\nName: {0}\n" +
                "Health: {1}/{2}\n" +
                "Attack value: {3}\n" +
                "Speed value: {4}\n" +
                "Defense value: {5}\n\n", name, Health, max_health, attack, speed, defense);
        }

        public int random_int_generator(int min_value, int max_value) // int min_value, int max_value are PARAMETERS
        {
            Random rnd = new Random();    // Creating a new OBJECT called rnd this is an 
                                                    // INSTANCE of RANDOM class

            int randomValue;

            randomValue = rnd.Next(min_value, max_value);  // Usine the NEXT method from the RANDOM class found in rnd OBJECT

            return randomValue;
        }
    
        public void about()
        {
            Console.WriteLine("I am a mystical species known as Hokemon!!");
        }

        public int attackCalculator()
        {
            int attackValue;

            // Adding an attack Calculation - 
            attackValue = (attack + speed) * random_int_generator(0,2);

            return attackValue;
        }

        public int defenceCalculator()
        {
            int defenceValue;

            // Adding an attack Calculation - 
            defenceValue = (defense + speed) * random_int_generator(0, 2);

            return defenceValue;
        }

    }
}
