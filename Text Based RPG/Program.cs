using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //The value for all multiple choice questions
            string Choice = null;
            Introduction();
            Tutorial();

            //altering the choice variable to be the users keystroke
            Choice = Console.ReadLine();

            //if the user enters the number 1, they are taken down this story line
            if (Choice == "1")
            {
                Console.WriteLine();
                Console.WriteLine("You decide to do the responsible thing and stay at home to work on your farm.");
                Console.WriteLine("With that old rusty sword you probably would not have made it that far, so it was probably for the better.");
                Console.WriteLine("The End.");
                Console.WriteLine("Press 'Enter' to exit the game");
                while (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                }
            }
            //if the user enters the number 2, they continue the story
            if (Choice == "2")
            {
                CaveChoice(Choice);
            }
        }

        /// <summary>
        /// The introduction to the story, which is just a lot of print statements
        /// </summary>
        static void Introduction()
        {
            Console.WriteLine("Welcome to a brand new world, Created entirely from my mind alone");
            Console.WriteLine("Although it does take a lot of inspiration from other MMO RPG's");
            Console.WriteLine();
            Console.WriteLine("On a mysterious continent by the name of Grigantor you find yourself on your farm craving adventure.");
            Console.WriteLine("On this farm you are surrounded by endlessly rolling plains with a small forest to your east. ");
            Console.WriteLine("You must decide wether or not to continue your boring life as a farmer(1),");
            Console.WriteLine("or to take up your old rusty sword and explore the woods to the east(2)");
        }

        /// <summary>
        /// The tutorial that teaches the user how to play the game using a bunch of print statements
        /// </summary>
        static void Tutorial()
        {
            Console.WriteLine();
            Console.WriteLine("To make a decision type the number that is displayed right after the decision you would like to make.");
            Console.WriteLine("Next, press enter to solidify your decision");
            Console.WriteLine();
        }

        /// <summary>
        /// The choice to go into the cave or continue on
        /// </summary>
        /// <param name="Choice"></param>
        static void CaveChoice(String Choice)
        {
            Console.WriteLine();
            Console.WriteLine("You decide to pick up your old rusty sword and venture off into the woods abandoning your farm to either be captured or fall into decay.");
            Console.WriteLine("As you venture deeper into the woods, a cave appears before you, its dark mouth beckoning you to enter.");
            Console.WriteLine("Doubts creep into your mind, fear begins to set in and you tell yourself that you should just move on.(1)");
            Console.WriteLine(" or you could find a torch but then the cave might be looted by the time you get back. (2)");
            Console.WriteLine(",or you could just dive right in. and get to any loot that might be in there first.(3)");
            Console.WriteLine();
            Choice = Console.ReadLine();

            //The gane over choice
            if (Choice == "1")
            {
                Console.WriteLine();
                Console.WriteLine("You let your fear control your actions and you decide to ignore your call to explore the cave, So you continue your hike through the woods");
                Console.WriteLine("As you continue your adventure, you come accross a figure dressed in black standing in your path with his sword drawn.");
                Console.WriteLine("You draw your own sword ready to defend yourself. He initiates combat by swinging his sword at you. You bring your sword up to parry him.");
                Console.WriteLine("His strike goes right through your sword, breaking your sword in two and splitting your skull killing you instantly. ");
                Console.WriteLine("Game Over.");
                Console.WriteLine(" Press 'Enter' to exit the game");
                while (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                }
            }
            //The choice to go into the cave
            if (Choice == "2")
            {
                InsideTheCave();
            }

            //The other game over choice
            if (Choice == "3")
            {
                Console.WriteLine();
                Console.WriteLine("You let the fire of adventure call you into the cave. You decide to enter the cave");
                Console.WriteLine("As you enter deeper into the cave, darkness begins to envelop you. Each of your steps echoing through the cave.");
                Console.WriteLine("You feel your feet give way a little as you step on what appears to be some loos ground");
                Console.WriteLine("ropes shoot out of the walls wrapping around you in great haste constricting you. Choking you.");
                Console.WriteLine("You fall over unable to do anything as you struggle for breath, but at this point you have already breathed your last.");
                Console.WriteLine("Game Over.");
                Console.WriteLine(" Press 'Enter' to exit the game");
                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                {
                }
            }
        }

        /// <summary>
        /// The segment of the story where the user is inside a cave
        /// </summary>
        static void InsideTheCave()
        {
            string Choice;
            Console.WriteLine();
            Console.WriteLine("Being a little frightened of entering a dark cave without a source of light,");
            Console.WriteLine("you decide to scavenge around for a torch before entering. While your scavenging,");
            Console.WriteLine("you notice a figure dressed in black enter the cave wielding a pretty nice sword, much shinier than yours");
            Console.WriteLine("With torch in hand you follow him inside the cave. On the walls there are some inscription written.");
            Console.WriteLine("These inscription warn you of the dangers of the cave, warning of ropes that will choke you, and spike traps.");
            Console.WriteLine("You notice buttons littered around the floor, and you take great care to avoid stepping on them.");
            Console.WriteLine("Then you notice a body lying on the floor a little ways ahead.");
            Console.WriteLine("After closer inspection you realize it was the figure from earlier dressed in black.");
            Console.WriteLine("There are ropes rapped all around him squeazing around his neck, his face is purple and the whites of his eyes are red.");
            Console.WriteLine("You notice his sword shining right next to him. He won't be needing that anymore, so you take it.");
            Console.WriteLine("You make your way deeper into the cave, and at the very end, you see waiting in the back a demon guarding a treasure chest.");
            Console.WriteLine("You ask the demon whats in the treasure chest, and he responds.");
            Console.WriteLine();
            Console.WriteLine("Demon: Just knowing that it exists makes you a dead man!");
            Console.WriteLine();
            Console.WriteLine("You: Not if I kill you first!(1)");
            Console.WriteLine("You: But I don't know that it exists.(2)");
            Console.WriteLine("Take a step back.(3)");
            Choice = Console.ReadLine();
            //The violent chocie
            if (Choice == "1")
            {

                Console.WriteLine("You unsheath your sword and take a combat stance");
                Console.WriteLine("You feel the ground shake beneath as you stare into the eyes of the demon. He lowers his head, his menacing horns pointed at you,");
                Console.WriteLine("And he begins to charge at you. You jump out of the way and swing your sword at his side, drawing his crimson blood, some of it landing on your arms burning you.");
                Console.WriteLine("Enraged, the demon screams at you charging up to launch fire at you. You duck behind the treasure chest.");
                Console.WriteLine("The demons fire impacts the chest burning it down revealing that inside was a shiny metal shield impervious to the demons fire.");
                Console.WriteLine("You pick up the shield and quickly pull it up infront of you as the demon blows fire onto you.");
                Console.WriteLine("You walk through the flames holding up the shield. You bash the shield right onto the demons mouth dazing it.");
                Console.WriteLine("You then stab the demon opening up another wound in his chest. He falls to his knees blood pooring from both his wounds.");
                Console.WriteLine("You grab him by one of his horns and stare into his eyes as you take the sword and sever his head from his body.");
                Console.WriteLine("The body of the demon falls over, and still holding the head you watch as the life drains from the demons eyes.");
                Console.WriteLine();
                Console.WriteLine("You have reached the end of this alpha. Press enter to exit.");
                while (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                }
            }
            //The peaceful choice
            if (Choice == "2")
            {
                Console.WriteLine("(you lie through your teeth denying it's existence)");
                Console.WriteLine("Demon: What? you were just asking about it!");
                Console.WriteLine();
                Console.WriteLine("You: No I wasn't, you must have been daydreaming");
                Console.WriteLine();
                Console.WriteLine("Demon: But can't you see it right behend me!");
                Console.WriteLine();
                Console.WriteLine("You: No, as far as I see you are the only thing in this cave besided myself.");
                Console.WriteLine();
                Console.WriteLine("Demon: Then just know that you have no buisness in the cave! Leave now!");
                Console.WriteLine();
                Console.WriteLine("You turn around and make your way out of the cave careful not to die to traps and stuff on the the way out. You are glad to have survived the demon encounter");
                Console.WriteLine("After exiting the cave and adjusting your eyes, you see that you are surrounded by many men with the crest of a nearby country on their chests.");
                Console.WriteLine("All with arrows notched, aimed at you.");
                Console.WriteLine();
                Console.WriteLine("You have reached the end of this alpha. Press enter to exit.");
                while (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                }
            }
            //Game over choice
            if (Choice == "3")
            {
                Console.WriteLine("Scared of the demon you take a step back back, but your foot doesn't land on anything and you slip and fall.");
                Console.WriteLine("You land on one big spide piercing you right through your chest, you see its tip in front of you protruding with your heart at it's tip.");
                Console.WriteLine("your insides burn as you slide the rest of the way down the spike. you hear the demon laughing just outside the pit as your vision darkens and you slip into death.");
                Console.WriteLine("Game Over.");
                Console.WriteLine(" Press 'Enter' to exit the game");
                while (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                }
            }
        }
    }
}
