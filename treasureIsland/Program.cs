using System;

class TreasureIslandGame
{
    static void Main(string[] args)
    {
        string chest = @"
                  |                   |                  |                     |
 _________|________________.=""""_;=.______________|_____________________|_______
|                   |  ,-""_,=""""     `""=.|                  |
|___________________|__""=._o`""-._        `""=.______________|___________________
          |                `""=._o`""=._      _`""=._                     |
 _________|_____________________:=._o ""=._.""_.-=""'""=.__________________|_______
|                   |    __.--"" , ; `""=._o."" ,-""""""-._ "".   |
|___________________|_._""  ,. .` ` `` ,  `""-._""-._   "". '__|___________________
          |           |o`""=._` , ""` `; ."". ,  ""-._""-._; ;              |
 _________|___________| ;`-.o`""=._; ."" ` '`.""\` . ""-._ /_______________|_______
|                   | |o;    `""-.o`""=._``  '` "" ,__.--o;   |
|___________________|_| ;     (#) `-.o `""=.`_.--""_o.-; ;___|___________________
____/______/______/___|o;._    ""      `"".o|o_.--""    ;o;____/______/______/____
/______/______/______/_""=._o--._        ; | ;        ; ;/______/______/______/_
____/______/______/______/__""=._o--._   ;o|o;     _._;o;____/______/______/____
/______/______/______/______/____""=._o._; | ;_.--""o.--""_/______/______/______/_
____/______/______/______/______/_____""=.o|o_.--""""___/______/______/______/____
/______/______/______/______/______/______/______/______/______/______/_____ /
"

        Console.WriteLine(chest);

        Console.WriteLine("Welcome to Treasure Island.");
        Console.WriteLine("Your mission is to find the treasure.");

        Console.Write("You're at a fork in the road. Which way do you go? Left or right?\n");
        string which_way = Console.ReadLine().ToLower();

        if (which_way == "left")
        {
            Console.Write("You've come to a river. Do you swim across or wait for a boat? Enter 'swim' or 'wait.' \n");
            string swim = Console.ReadLine().ToLower();

            if (swim == "wait")
            {
                Console.Write("You see three doors. Pick one. Red, yellow, or blue? \n");
                string which_door = Console.ReadLine().ToLower();

                if (which_door == "yellow")
                {
                    Console.WriteLine("Congratulations. You found the treasure.");
                }
                else if (which_door == "red")
                {
                    Console.WriteLine("Upon turning the knob, the door erupts into flames. You are toast.");
                }
                else
                {
                    Console.WriteLine("Opening the door triggers a lone record player in the room. Eiffel 65's hit song 'I'm Blue' begins to play. It immediately gets stuck in your head forever. Madness is imminent. Game over.");
                }
            }
            else
            {
                Console.WriteLine("The river is full of electric eels that attack as soon as you step foot in the water. Game over.");
            }
        }
        else
        {
            Console.WriteLine("You continue walking a lonely road. Realizing you've gone the wrong way, you turn around to find nothing but straight road. There is no going back. Game over.");
        }
    }
}
