using System.Diagnostics.CodeAnalysis;

namespace variables_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //strings
            string heroFirstName = "Presley";
            string heroLastName = "Smith";
            string heroFullName;
            string villainTitle = "Not cool guy";
            string villainName;
            string minionTitle = "Fella";
            string minion1Name;
            string minion2Name;

            //ints
            int heroHealth = 100;
            int heroStrength = 50;
            int bossHealth = 100;
            int bossStrength = 25;
            int minion1Health = 50;
            int minion2Health = 50;
            int minionStrength = 5;


            //logs
            heroFullName = heroFirstName + " " + heroLastName;
            Console.WriteLine("Behold the legendary hero of Programming, whose name is: " + heroFullName);



            //villain / minion names
            villainName = "Gene";
            minion1Name = "Rob";
            minion2Name = "Banks";

            //villain announcement
            Console.WriteLine(heroFullName + "'s rival is " + villainName + " the " + villainTitle);
            Console.WriteLine(villainName + " is helped by " + minionTitle + " " + minion1Name + " and " + minionTitle + " " + minion2Name);


            //Int initializations
            Console.WriteLine("The fighters enter the room!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);
            Console.WriteLine("Minion 1's health: " + minion1Health);
            Console.WriteLine("Minion 2's health: " + minion2Health);


            //fight logs
            //boss attack
            Console.WriteLine(villainName + " the " + villainTitle + " attacks " + heroFullName);
            Console.WriteLine(villainName + " the " + villainTitle + " deals " + bossStrength + " damage!");

            //player health
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //minions attack
            Console.WriteLine("Fellas Attack!");
            Console.WriteLine(minion1Name + " deals " + minionStrength + " damage!");
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            Console.WriteLine(minion2Name + " deals " + minionStrength + " damage!");
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");


            //Hero Attack
            Console.WriteLine(heroFullName + " attacks each villain for " + heroStrength + " damage!");
            bossHealth -= heroStrength;
            minion1Health -= heroStrength;
            minion2Health -= heroStrength;

            //hero attack
            Console.WriteLine(villainName + " the " + villainTitle + " now has " + bossHealth + " healt1!");
            Console.WriteLine(minionTitle + " " + minion1Name + " now has " + minion1Health + " health!");
            Console.WriteLine(minionTitle + " " + minion2Name + " now has " + minion2Health + " health!");

            //minions dead
            Console.WriteLine(minion1Name + " and " + minion2Name + " have been eliminated");


            //heal
            Console.WriteLine(heroFullName + " has " + heroHealth + " health");
            Console.WriteLine(heroFullName + " drinks a health potion");
            heroHealth++;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");


            //finale
            Console.WriteLine("The fight continues");
            Console.WriteLine("Hero Health: " + heroHealth);
            Console.WriteLine("Boss Health: " + bossHealth);

            //boss attack
            Console.WriteLine(villainName + " the " + villainTitle + " attacks " + heroFullName);
            Console.WriteLine(villainName + " the " + villainTitle + " deals " + bossStrength + " damage!");

            //player health
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //hero attack
            Console.WriteLine(heroFullName + " attacks " + villainName + " the " + villainTitle + " for " + heroStrength + " damage!");
            bossHealth = bossHealth - heroStrength;
            Console.WriteLine(villainName + " the " + villainTitle + " now has " + bossHealth + " health!");

            //end
            Console.WriteLine(heroFullName + " has won");
            Console.WriteLine("Rip Gene. He sucked anyways");

        }
    }
}
