using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGameProgram
{
    public class Character
    {
        // private local variables for the Character class
        private string name;
        private int health;
        private List<string> inventory;
        private int attack;
        private int speed;
        private int defense;

        // public properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value;
                // Ensure that health cannot be set to a negative value
                if (value > 0)
            {
              health = value;

                }

            }
        }

        public List<string> Inventory
        {
            get { return inventory; }
            set { inventory = value; }
        }

        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }

        // building constructor for the Character class

        public Character(string new_name, int health, List<string> inventory, int attack, int speed, int defense)
        {
            Name = new_name;
            Health = health;
            Inventory = inventory;
            Attack = attack;
            Speed = speed;
            Defense = defense;
        }

        public Character(string new_name, int health, int attack, int speed, int defense)
        {
            Name = new_name;
            Health = health;
            Attack = attack;
            Speed = speed;
            Defense = defense;
        }

        public string Battle(bool hitLanded, int damage)
        {
            // If the hit landed, calculate the damage and update health
            if (hitLanded)
            {
                Health = Health - damage;

            }

            return $"Health is now {Health}";

        }

        // Method to display the character's information
        public string Display()
        {
            // Return a string with the character's name, health, attack, speed, and defense
            return $"Character: {Name} has {Health} health with {Attack} attack, {Speed} speed, and {Defense} defense.";


        }


    }
}
