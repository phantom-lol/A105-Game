using System;

namespace GAME
{
    internal class main
    {
        // Defining global variables for health, gold and respect. Also defining indicator to check if quest has already been completed
        static int respect = 0;
        static int gold = 0;
        static int health = 100;
        static int counter1 = 0;
        static int counter2 = 0;
        static int counter3 = 0;

        static void Quest1()
        {
            Console.Clear();

            // Displays ASCII tree
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("          &&& &&  & &&\r\n      && &\\/&\\|& ()|/ @, &&\r\n      &\\/(/&/&||/& /_/)_&/_&\r\n   &() &\\/&|()|/&\\/ '%\" & ()\r\n  &_\\_&&_\\ |& |&&/&__%_/_& &&\r\n&&   && & &| &| /& & % ()& /&&\r\n ()&_---()&\\&\\|&&-&&--%---()~\r\n     &&     \\|||\r\n             |||\r\n             |||\r\n             |||\r\n       , -=-~  .-^- _");
            Console.ResetColor();
            Console.WriteLine("");

            // Story text along with speech from character
            Console.WriteLine("You leave and make your way towards a park, where you find Margaret standing near a tree.");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("'Hello dear, sorry to be a bother, but it seems Mr Bigglesworth has gotten into a spot of trouble'");
            Console.WriteLine("");
            Console.ResetColor();

            Console.WriteLine("You look up into the tree, and you spot a small orange cat perched on one of the branches.\nAs you look up at it, it lets out a small meow.");
            Console.WriteLine("");

            // Defining decision variables and random element
            string catDecision;
            string catMonster;
            Random rand = new Random();

            // Do while loop used so that code will loop if invalid answer is input
            do
            {
                // Decision ToLower so that it is not case sensitive
                Console.WriteLine("Do you want to:\na) Save the cat\nb) Leave the cat\nPlease make your decision: ");
                catDecision = Console.ReadLine().ToLower();
                Console.Clear();

                // rand.Next(1, 5) shows 1 in 4 chance of random event happening
                if (catDecision == "a" && rand.Next(1, 5) != 3)
                {
                    // Positive outcome
                    Console.WriteLine("You climb up the tree and reach the cat, gently calling out to it as it slowly walks towards your arm.\nAs it reaches your arm, you hold it close and safely make your way back down the tree, returning it to Margaret.");
                    
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("");
                    Console.WriteLine("Thank you so much, dear. I don't know what I would've done without you. Here, take this for your troubles.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    gold += 20;
                    respect += 15;
                    counter1 += 1;
                    Console.WriteLine("");
                    Console.WriteLine($"You gained 20 gold. Your total gold balance is now {gold}");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("");
                    Console.WriteLine($"You gained 15 respect. Your total respect is now {respect}");
                    Console.ResetColor();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                } else if (catDecision == "b")
                {
                    // Negative outcome
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("");
                    Console.WriteLine("Well I say! How rude of you! The whole town will know about this.");
                    Console.ForegroundColor = ConsoleColor.Red;
                    respect -= 40;
                    counter1 += 1;
                    Console.WriteLine("");
                    Console.WriteLine($"You lost 40 respect. Your total respect is now {respect}");
                    Console.ResetColor();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                } else if (rand.Next(1, 5) == 3)
                {
                    // Random event
                    Console.WriteLine("As you begin to climb the tree, you hear a low growling emitting from the cat's mouth. You look up, and the cat jumps at you, hitting you off of the tree.");
                    Console.WriteLine("You hit the floor with a lot of force, and take a couple seconds to regain your bearings. When you do, you realise that the cat has transformed into some sort of... creature.");
                    Console.WriteLine("");
                    
                    Console.WriteLine("You stand up and face the creature, realising how big it has become.");
                    Console.WriteLine("You think about the actions that you can take. Do you:\na) Fight the creature\nb) Flee\nPlease make your decision: ");
                    catMonster = Console.ReadLine().ToLower();

                    do
                    {
                        if (catMonster == "a")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("                            /|\r\n                          /'||\r\n                         |  ||\r\n                         |  ||\r\n                         |  ||\r\n                         |  ||\r\n                         |  ||\r\n                         |  ||\r\n                         |  ||\r\n                         |  ||\r\n                         |  ||\r\n                         |  ||\r\n                         |  ||\r\n                         |  ||\r\n                         |  ||\r\n                         |  ||\r\n                         |  ||         __.--._\r\n                         |  ||      /~~   __.-~\\ _\r\n                         |  ||  _.-~ / _---._ ~-\\/~\\\r\n                         |  || // /  /~/  .-  \\  /~-\\\r\n                         |  ||((( /(/_(.-(-~~~~~-)_/ |\r\n                         |  || ) (( |_.----~~~~~-._\\ /\r\n                         |  ||    ) |              \\_|\r\n                         |  ||     (| =-_   _.-=-  |~)        ,\r\n                         |  ||      | `~~ |   ~~'  |/~-._-'/'/_,\r\n                         |  ||       \\    |        /~-.__---~ , ,\r\n                         |  ||       |   ~-''     || `\\_~~~----~\r\n                         |  ||_.ssSS$$\\ -====-   / )\\_  ~~--~\r\n                 ___.----|~~~|%$$$$$$/ \\_    _.-~ /' )$s._\r\n        __---~-~~        |   |%%$$$$/ /  ~~~~   /'  /$$$$$$$s__\r\n      /~       ~\\    ============$$/ /        /'  /$$$$$$$$$$$SS-.\r\n    /'      ./\\\\\\\\\\\\_( ~---._(_))$/ /       /'  /$$$$%$$$$$~      \\\r\n    (      //////////(~-(..___)/$/ /      /'  /$$%$$%$$$$'         \\\r\n     \\    |||||||||||(~-(..___)$/ /  /  /'  /$$$%$$$%$$$            |\r\n      `-__ \\\\\\\\\\\\\\\\\\\\\\(-.(_____) /  / /'  /$$$$%$$$$$%$             |\r\n          ~~\"\"\"\"\"\"\"\"\"\"-\\.(____) /   /'  /$$$$$%%$$$$$$\\_            /\r\n                        $|===|||  /'  /$$$$$$$%%%$$$$$( ~         ,'|\r\n                    __  $|===|%\\/'  /$$$$$$$$$$$%%%%$$|        ,''  |\r\n                   ///\\ $|===|/'  /$$$$$$%$$$$$$$%%%%$(            /'\r\n                    \\///\\|===|  /$$$$$$$$$%%$$$$$$%%%%$\\_-._       |\r\n                     `\\//|===| /$$$$$$$$$$$%%%$$$$$$-~~~    ~      /\r\n                       `\\|-~~(~~-`$$$$$$$$$%%%///////._       ._  |\r\n                       (__--~(     ~\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\        \\ \\\r\n                       (__--~~(       \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\|        \\/\r\n                        (__--~(       ||||||||||||||||||/       _/\r\n                         (__.--._____//////////////////__..---~~\r\n                         |   \"\"\"\"'''''           ___,,,,ss$$$%\r\n                        ,%\\__      __,,,\\sssSS$$$$$$$$$$$$$$%%\r\n                      ,%%%%$$$$$$$$$$\\;;;;\\$$$$$$$$$$$$$$$$%%%$.\r\n                     ,%%%%%%$$$$$$$$$$%\\;;;;\\$$$$$$$$$$$$%%%$$$$\r\n                   ,%%%%%%%%$$$$$$$$$%$$$\\;;;;\\$$$$$$$$$%%$$$$$$,\r\n                  ,%%%%%%%%%$$$$$$$$%$$$$$$\\;;;;\\$$$$$$%%$$$$$$$$\r\n                 ,%%%%%%%%%%%$$$$$$%$$$$$$$$$\\;;;;\\$$$%$$$$$$$$$$$\r\n                 %%%%%%%%%%%%$$$$$$$$$$$$$$$$$$\\;;;$$$$$$$$$$$$$$$\r\n                   \"\"==%%%%%%%$$$$$TuaXiong$$$$$$$$$$$$$$$$$$$SV\"\r\n                               $$$$$$$$$$$$$$$$$$$$====\"\"\"\"\r\n                                 \"\"\"\"\"\"\"\"\"~~~~\r\n\r\n\r\n\r\n");
                            Console.ResetColor();
                            Console.WriteLine("You unsheathe your sword, and prepare yourself to fight.");
                            Console.WriteLine("The creature dives towards you, clawing at your arm. As it does, you raise your sword and lunge straight into the creature, penetrating its flesh.");
                            Console.WriteLine("");
                            Console.WriteLine("You remove your sword from the creature, bleeding out slowly on the floor. You grab your arm as a searing pain flows through your arm.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.Clear();

                            respect += 60;
                            gold += 40;
                            health -= 50;
                            counter1 += 1;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine($"You gained 60 respect. Your total respect is now {respect}");

                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"You gained double the amount of gold promised for your valiant effort. Your total gold is now {gold}");
                            Console.WriteLine("");
                            
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"You lost 50 health. Your total health is now {health}");
                            Console.ResetColor();
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                        } else if (catMonster == "b")
                        {
                            Console.Clear();
                            Console.WriteLine("    ) )        /\\\r\n   =====      /  \\\r\n  _|___|_____/ __ \\____________\r\n |::::::::::/ |  | \\:::::::::::|\r\n |:::::::::/  ====  \\::::::::::|\r\n |::::::::/__________\\:::::::::|\r\n |_________|  ____  |__________|\r\n  | ______ | / || \\ | _______ |\r\n  ||  |   || ====== ||   |   ||\r\n  ||--+---|| |    | ||---+---||\r\n  ||__|___|| |   o| ||___|___||\r\n  |========| |____| |=========|\r\n (^^-^^^^^-|________|-^^^--^^^)\r\n (,, , ,, ,/________\\,,,, ,, ,)\r\n','',,,,' /__________\\,,,',',;;");
                            Console.WriteLine("");

                            Console.WriteLine("You turn your back to the monster, running as fast as you can.");
                            Console.WriteLine("When you eventually stop running, you reach the town again, and you are greeted by your temporary house.");
                            Console.WriteLine("");

                            respect -= 30;
                            counter1 += 1;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"You lost 30 respect for fleeing. Your total respect is now {respect}");
                            Console.ResetColor();
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    } while (catMonster != "a" && catMonster != "b");

                }
            } while (catDecision != "a" && catDecision != "b");
        }

        static void Quest2()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                      .      .       .       .\r\n  .   .       .          .      . .      .         .          .    .\r\n         .       .         .    .   .         .         .            .\r\n    .   .    .       .         . . .        .        .     .    .\r\n .          .   .       .       . .      .        .  .              .\r\n      .  .    .  .       .     . .    .       . .      .   .        .\r\n .   .       .    . .      .    . .   .      .     .          .     .\r\n    .            .    .     .   . .  .     .   .               .\r\n     .               .  .    .  . . .    .  .                 .\r\n                        . .  .  . . .  . .\r\n                            . . . . . .\r\n                              . . . .\r\n                               I . I\r\n                 _______________III_______________\r\n                /    .       .       .       .    \\\r\n               ( ~~~ .  ~~~  .  ~~~  .  ~~~  . ~~~ )\r\n                 \\SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS/\r\n                    \\ ======================= /\r\n                        \\SSSSSSSSSSSSSSSSS/\r\n                     ________\\       /________\r\n                    (=+=+=+=+=+=+=+=+=+=+=+=+=)\r\n                     ~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ResetColor();

            Console.WriteLine("You make your way to the King, who is standing by a fountain");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.WriteLine("Oh, hello young chap. Are you the one they sent to escort me today?");
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("You nod your head in response");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ah, well we should head off then");
            Console.WriteLine("");
            Console.ResetColor();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You begin walking in the direction of the palace.");
            Console.WriteLine("As you reach about halfway, you hear a loud growling sound coming from the trees. You draw your sword and stand infront of the king in a defensive stance.");
            Console.WriteLine("You see a large monster emerge from the trees, growling aggressively at you");
            Console.WriteLine("");
            Console.WriteLine("Do you want to:\na) Fight the monster\nb) Flee with the King\nPlease make your decision: ");
            string kingDecision = Console.ReadLine().ToLower();

            do
            {
                if (kingDecision == "a")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("                                              ,--,  ,.-.\r\n                ,                   \\,       '-,-`,'-.' | ._\r\n               /|           \\    ,   |\\         }  )/  / `-,',\r\n               [ '          |\\  /|   | |        /  \\|  |/`  ,`\r\n               | |       ,.`  `,` `, | |  _,...(   (      _',\r\n               \\  \\  __ ,-` `  ,  , `/ |,'      Y     (   \\_L\\\r\n                \\  \\_\\,``,   ` , ,  /  |         )         _,/\r\n                 \\  '  `  ,_ _`_,-,<._.<        /         /\r\n                  ', `>.,`  `  `   ,., |_      |         /\r\n                    \\/`  `,   `   ,`  | /__,.-`    _,   `\\\r\n                -,-..\\  _  \\  `  /  ,  / `._) _,-\\`       \\\r\n                 \\_,,.) /\\    ` /  / ) (-,, ``    ,        |\r\n                ,` )  | \\_\\       '-`  |  `(               \\\r\n               /  /```(   , --, ,' \\   |`<`    ,            |\r\n              /  /_,--`\\   <\\  V /> ,` )<_/)  | \\      _____)\r\n        ,-, ,`   `   (_,\\ \\    |   /) / __/  /   `----`\r\n       (-, \\           ) \\ ('_.-._)/ /,`    /\r\n       | /  `          `/ \\\\ V   V, /`     /\r\n    ,--\\(        ,     <_/`\\\\     ||      /\r\n   (   ,``-     \\/|         \\-A.A-`|     /\r\n  ,>,_ )_,..(    )\\          -,,_-`  _--`\r\n (_ \\|`   _,/_  /  \\_            ,--`\r\n  \\( `   <.,../`     `-.._   _,-`\r\n   `                      ```");
                    Console.ResetColor();
                    Console.WriteLine("You dash towards the monster, swinging at it with immense force. You land a hit on the monster, slashing your blade through its arm.");
                    Console.WriteLine("It lets out a loud roar, then quickly swings back at you, hitting you against a tree.");
                    Console.WriteLine("It charges at you again, aiming at your chest.");
                    Console.WriteLine("You quickly dash to the left and stab your sword into the monsters mouth. You push it up, killing the monster instantly.");
                    Console.WriteLine("You drop to your knee, catching your breathe and tending to your wounds, before returning to the King.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("");
                    Console.WriteLine("Jolly good show!");
                    Console.ResetColor();
                    Console.WriteLine("");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("                           !\r\n                          /^\\\r\n                        /     \\\r\n     |               | (       ) |               |\r\n    /^\\  |          /^\\ \\     / /^\\          |  /^\\\r\n    |O| /^\\        (   )|-----|(   )        /^\\ |O|\r\n    |_| |-|    |^-^|---||-----||---|^-^|    |-| |_|\r\n    |O| |O|    |/^\\|/^\\||  |  ||/^\\|/^\\|    |O| |O|\r\n    |-| |-|    ||_|||_||| /^\\ |||_|||_||    |-| |-|\r\n    |O| |O|    |/^\\|/^\\||(   )||/^\\|/^\\|    |O| |O|\r\n    |-| |-|    ||_|||_||||   ||||_|||_||    |-| |-|\r\n    |O| |_|----|___|___|||___|||___|_|_|    |O| |O|\r\n    |_|                                         |_|\r\n       /_______________________________________\\\r\n    __|_______________________________________|___|");
                    Console.WriteLine("");
                    Console.WriteLine("You arrive at the King's palace, and open the door for the King.");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Thank you for escorting me. If it wasn't for you, I wouldn't have made it here!");
                    Console.WriteLine("");
                    Console.ResetColor();

                    gold += 75;
                    respect += 50;
                    health -= 40;
                    counter2 += 1;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Your gold increased from fighting the monster. Your total gold is now {gold}");
                    Console.WriteLine("");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"Your respect increased from fighting the monster. Your total respect is now {respect}");
                    Console.WriteLine("");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Your health decreased from fighting the monster. Your total health is now {health}");
                    Console.WriteLine("");
                    Console.ResetColor();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                } else if (kingDecision == "b")
                {
                    Console.WriteLine("You turn around and grab the King, before running as fast as you can.");
                    Console.WriteLine("Press any key to continue...");
                    Console.Clear();

                    Console.WriteLine("                           !\r\n                          /^\\\r\n                        /     \\\r\n     |               | (       ) |               |\r\n    /^\\  |          /^\\ \\     / /^\\          |  /^\\\r\n    |O| /^\\        (   )|-----|(   )        /^\\ |O|\r\n    |_| |-|    |^-^|---||-----||---|^-^|    |-| |_|\r\n    |O| |O|    |/^\\|/^\\||  |  ||/^\\|/^\\|    |O| |O|\r\n    |-| |-|    ||_|||_||| /^\\ |||_|||_||    |-| |-|\r\n    |O| |O|    |/^\\|/^\\||(   )||/^\\|/^\\|    |O| |O|\r\n    |-| |-|    ||_|||_||||   ||||_|||_||    |-| |-|\r\n    |O| |_|----|___|___|||___|||___|_|_|    |O| |O|\r\n    |_|                                         |_|\r\n       /_______________________________________\\\r\n    __|_______________________________________|___|");
                    Console.WriteLine("You eventually make it to the palace, where you let go of the King and catch your breathe.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("");
                    Console.WriteLine("You saved me, but you are a coward.");
                    Console.ResetColor();
                    Console.WriteLine("");

                    Console.WriteLine("The King shuts the door in your face");

                    gold += 25;
                    respect -= 30;
                    counter2 += 1;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("");
                    Console.WriteLine($"You gained 25 gold. Your total gold is now {gold}");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("");
                    Console.WriteLine($"You lost 30 respect. Your total respect is now {respect}");
                    Console.ResetColor();
                    Console.WriteLine("");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            } while (kingDecision != "a" && kingDecision != "b");




        }

        static void Quest3()
        {
            Console.Clear();
            Console.WriteLine("You head down to the dungeon, as a cold breeze hits you.");
            Console.WriteLine("As you reach the bottom of the stairs, you see the dragon in the corner of your eye");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                                       ____________\r\n                                 (`-..________....---''  ____..._.-`\r\n                                  \\\\`._______.._,.---'''     ,'\r\n                                  ; )`.      __..-'`-.      /\r\n                                 / /     _.-' _,.;;._ `-._,'\r\n                                / /   ,-' _.-'  //   ``--._``._\r\n                              ,','_.-' ,-' _.- (( =-    -. `-._`-._____\r\n                            ,;.''__..-'   _..--.\\\\.--'````--.._``-.`-._`.\r\n             _          |\\,' .-''        ```-'`---'`-...__,._  ``-.`-.`-.`.\r\n  _     _.-,'(__)\\__)\\-'' `     ___  .          `     \\      `--._\r\n,',)---' /|)          `     `      ``-.   `     /     /     `     `-.\r\n\\_____--.  '`  `               __..-.  \\     . (   < _...-----..._   `.\r\n \\_,--..__. \\\\ .-`.\\----'';``,..-.__ \\  \\      ,`_. `.,-'`--'`---''`.  )\r\n           `.\\`.\\  `_.-..' ,'   _,-..'  /..,-''(, ,' ; ( _______`___..'__\r\n                   ((,(,__(    ((,(,__,'  ``'-- `'`.(\\  `.,..______   SSt\r\n                                                      ``--------..._``--.__");
            Console.ResetColor();
            Console.WriteLine("");

            Console.WriteLine("You unsheathe your sword, preparing for the battle of a lifetime.");
            Console.WriteLine("");
            Console.WriteLine("The dragon flies at you with speed, smacking its wing into you, knocking your down.");
            Console.WriteLine("As it circles round, you jump to your feet, then throw your sword at it, hitting its wing.");
            Console.WriteLine("The dragon lets out a loud screech, hitting the floor violently.");
            Console.WriteLine("You go to retrieve your sword, but as you do, the dragon bites you.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            if (health <= 50)
            {
                Console.Clear();
                Console.WriteLine("As its teeth sink into you, you feel your life slipping away.");
                Console.WriteLine("Your try to hold onto your sword, but you feel your grip getting looser and looser.");
                Console.WriteLine("You look back up, and catch a final glimse of the dragon as it flies away.");
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You died. Better luck next time.");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("Press any key to close the game...");
                Console.ReadKey();
                Environment.Exit(0);
            } else if (health > 50)
            {
                Console.Clear();
                Console.WriteLine("A searing pain runs through your body like nothing you have ever felt before. However, you refuse to give up.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Your grip your sword as hard as you can, and rip it out of the dragon's wing and plunge it into its head.");
                Console.WriteLine("You feel its bite strength weaken, and you slip away from it, staggering until you fall over.");
                Console.WriteLine("You clutch at the bite marks on your chest, wincing in pain. Your vision starts to become blurry, and you eventually pass out.");
                Console.WriteLine("");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("            .---------.\r\n       _    |:: [-=-] |\r\n      | |   |_________|\r\n      |~|\r\n      |_|                    ,;;;;,\r\n       I\\  ,__ ,;;;, __,    ///\\\\\\\\\\\r\n       I |{   / . . \\   }   / \"  \\\\||\r\n       I | ) (   _   ) (    \\_= _///\r\n       I |{___'-. .-'___}\\___ )_\\\r\n       I ||~/,'~~~~~,\\~~|'---((  \\\r\n       I \\ //        \\\\ |     \\ \\ \\\r\n       I  \\/         // |     | /-/\r\n       I (/         (/  |     |/||\\\r\n       I  |             |     |    |\r\n       I  |             |     |____/\r\n       I  :-----_o_-----:      || |\r\n       I  | /~~|===|~~\\ |      (( |\r\n       I  ||   |===|   ||      ||_/\r\n      /^\\ \"~   '^^^'   \"\"     ((__|");
                Console.WriteLine("You awake in a hospital bed, your wounds all bandaged up. A nurse comes over to you.");
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("I was wondering when you would wake up!");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("You let out a little chuckle, then slowly sit up.");
                Console.WriteLine("");

                gold += 100;
                respect += 60;
                health -= 50;
                counter3 += 1;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"You gained 100 gold. Your total gold is now {gold}");
                Console.ResetColor();
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"You gained 60 respect. Your total respect is now {respect}");
                Console.ResetColor();
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You lost 50 health Your total health is now {health}");
                Console.ResetColor();
                Console.WriteLine("");
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {

            // Printing title
            string title = "  ______      __    __   _______     _______.___________.    __    __   __    __  .__   __. .___________. _______ .______      \r\n /  __  \\    |  |  |  | |   ____|   /       |           |   |  |  |  | |  |  |  | |  \\ |  | |           ||   ____||   _  \\     \r\n|  |  |  |   |  |  |  | |  |__     |   (----`---|  |----`   |  |__|  | |  |  |  | |   \\|  | `---|  |----`|  |__   |  |_)  |    \r\n|  |  |  |   |  |  |  | |   __|     \\   \\       |  |        |   __   | |  |  |  | |  . `  |     |  |     |   __|  |      /     \r\n|  `--'  '--.|  `--'  | |  |____.----)   |      |  |        |  |  |  | |  `--'  | |  |\\   |     |  |     |  |____ |  |\\  \\----.\r\n \\_____\\_____\\\\______/  |_______|_______/       |__|        |__|  |__|  \\______/  |__| \\__|     |__|     |_______|| _| `._____|\r\n                                                                                                                               ";
            Console.WriteLine(title);

            // Printing title text
            Console.WriteLine("Welcome to Quest Hunter!");
            Console.WriteLine("");
            Console.WriteLine("In this game, you will find yourself in several different situations, which will all require a choice to be made.");
            Console.WriteLine("To choose one of the options, simply enter the letter of the option you want to choose.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            //Printing ASCII house and first scene text
            Console.WriteLine("             (\r\n                )\r\n            (            ./\\.\r\n         |^^^^^^^^^|   ./LLLL\\.\r\n         |`.'`.`'`'| ./LLLLLLLL\\.\r\n         |.'`'.'`.'|/LLLL/^^\\LLLL\\.\r\n         |.`.''``./LLLL/^ () ^\\LLLL\\.\r\n         |.'`.`./LLLL/^  =   = ^\\LLLL\\.\r\n         |.`../LLLL/^  _.----._  ^\\LLLL\\.\r\n         |'./LLLL/^ =.' ______ `.  ^\\LLLL\\.\r\n         |/LLLL/^   /|--.----.--|\\ = ^\\LLLL\\.\r\n       ./LLLL/^  = |=|__|____|__|=|    ^\\LLLL\\.\r\n     ./LLLL/^=     |*|~~|~~~~|~~|*|   =  ^\\LLLL\\.\r\n   ./LLLL/^        |=|--|----|--|=|        ^\\LLLL\\.\r\n ./LLLL/^      =   `-|__|____|__|-' =        ^\\LLLL\\.\r\n/LLLL/^   =         `------------'        =    ^\\LLLL\\\r\n~~|.~       =        =      =          =         ~.|~~\r\n  ||     =      =      = ____     =         =     ||\r\n  ||  =               .-'    '-.        =         ||\r\n  ||     _..._ =    .'  .-()-.  '.  =   _..._  =  ||\r\n  || = .'_____`.   /___:______:___\\   .'_____`.   ||\r\n  || .-|---.---|-.   ||  _  _  ||   .-|---.---|-. ||\r\n  || |=|   |   |=|   || | || | ||   |=|   |   |=| ||\r\n  || |=|___|___|=|=  || | || | ||=  |=|___|___|=| ||\r\n  || |=|~~~|~~~|=|   || | || | ||   |=|~~~|~~~|=| ||\r\n  || |*|   |   |*|   || | || | ||  =|*|   |   |*| ||\r\n  || |=|---|---|=| = || | || | ||   |=|---|---|=| ||\r\n  || |=|   |   |=|   || | || | ||   |=|   |   |=| ||\r\n  || `-|___|___|-'   ||o|_||_| ||   `-|___|___|-' ||\r\n  ||  '---------`  = ||  _  _  || =  `---------'  ||\r\n  || =   =           || | || | ||      =     =    ||\r\n  ||  %@&   &@  =    || |_||_| ||  =   @&@   %@ = ||\r\n  || %@&@% @%@&@    _||________||_   &@%&@ %&@&@  ||\r\n  ||,,\\\\V//\\\\V//, _|___|------|___|_ ,\\\\V//\\\\V//,,||\r\n  |--------------|____/--------\\____|--------------|\r\n /- _  -  _   - _ -  _ - - _ - _ _ - _  _-  - _ - _ \\\r\n/____________________________________________________\\");
            Console.WriteLine("");
            Console.WriteLine("You wake with a start, a strong scent of alcohol filling your nose. As you raise your head off the table, you find yourself in a cozy tavern, filled with life.");
            Console.WriteLine("As you begin to wake up more, you look around, surveying your surroundings. As you do this, your eyes focus onto a scroll that was placed on the table.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // Printing scroll with quests
            Console.WriteLine($".-.---------------------------------.-.\r\n((o))                                   )\r\n\\U/_______          _____         ____/\r\n|                                  |\r\n| Welcome, traveller,              |\r\n|                                  |\r\n| I am the quest master, and I have|\r\n| three quests that I want you to  |\r\n| complete for me.                 |\r\n| 1. Help Margaret save her cat    |\r\n| 2. Escort the King to his palace |\r\n| 3. Slay the dragon in the dungeon|\r\n| You have 4 days to finish them.  |\r\n| - Quest Master                   |\r\n|____    _______    __  ____    ___|\r\n/A\\                                  \\\r\n((o))                                  )\r\n'-'----------------------------------'");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            string userChoice = "";

            // For loop used for day system to track how many days the user has been going. Once day 4 is over, the loop will end
            for (int i = 1; i < 4; i++)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine($"It is now Day {i}, you have {4 - i} days left.");
                    Console.WriteLine("");
                    Console.WriteLine("Which quest would you like to take on today?\na) Helping Margaret save her cat\nb) Escorting the King to his palace\nc) Fighting the dragon in the dungeon\nPlease make your decision: ");
                    userChoice = Console.ReadLine().ToLower();

                    // Use of subroutines for each quest
                    if (userChoice == "a")
                    {
                        Quest1();
                    }
                    else if (userChoice == "b")
                    {
                        Quest2();
                    }
                    else if (userChoice == "c")
                    {
                        Quest3();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid answer, please try again.");
                        Console.ResetColor();
                    }
                } while (userChoice != "a" && userChoice != "b" && userChoice != "c");
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                      .      .       .       .\r\n  .   .       .          .      . .      .         .          .    .\r\n         .       .         .    .   .         .         .            .\r\n    .   .    .       .         . . .        .        .     .    .\r\n .          .   .       .       . .      .        .  .              .\r\n      .  .    .  .       .     . .    .       . .      .   .        .\r\n .   .       .    . .      .    . .   .      .     .          .     .\r\n    .            .    .     .   . .  .     .   .               .\r\n     .               .  .    .  . . .    .  .                 .\r\n                        . .  .  . . .  . .\r\n                            . . . . . .\r\n                              . . . .\r\n                               I . I\r\n                 _______________III_______________\r\n                /    .       .       .       .    \\\r\n               ( ~~~ .  ~~~  .  ~~~  .  ~~~  . ~~~ )\r\n                 \\SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS/\r\n                    \\ ======================= /\r\n                        \\SSSSSSSSSSSSSSSSS/\r\n                     ________\\       /________\r\n                    (=+=+=+=+=+=+=+=+=+=+=+=+=)\r\n                     ~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("It is now Day 4, and you find the Quest Master waiting for you at town's fountain.");

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Well, well, well, let's see how well you did, eh?");
            Console.WriteLine("");
            Console.ResetColor();

            Console.WriteLine("He pulls out a sheet of paper and studies it carefully.");

            if (counter1 != 0 && counter2 != 0 && counter3 != 0  && respect > 40)
            {
                Console.WriteLine("He looks over at you and smiles");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("");
                Console.WriteLine("Well done! You have succesfully completed all of my quests!");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("The whole town cheers at your triumph, and immediately beckons you to the tavern to celebrate.");

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("        ,,,,,,,,,,,,,\r\n    .;;;;;;;;;;;;;;;;;;;,.\r\n  .;;;;;;;;;;;;;;;;;;;;;;;;,\r\n.;;;;;;;;;;;;;;;;;;;;;;;;;;;;.\r\n;;;;;@;;;;;;;;;;;;;;;;;;;;;;;;' .............\r\n;;;;@@;;;;;;;;;;;;;;;;;;;;;;;;'.................\r\n;;;;@@;;;;;;;;;;;;;;;;;;;;;;;;'...................\r\n`;;;;@;;;;;;;;;;;;;;;@;;;;;;;'.....................\r\n `;;;;;;;;;;;;;;;;;;;@@;;;;;'..................;....\r\n   `;;;;;;;;;;;;;;;;@@;;;;'....................;;...\r\n     `;;;;;;;;;;;;;@;;;;'...;.................;;....\r\n        `;;;;;;;;;;;;'   ...;;...............;.....\r\n           `;;;;;;'        ...;;..................\r\n              ;;              ..;...............\r\n              `                  ............\r\n             `                      ......\r\n            `                         ..\r\n           `                           '\r\n          `                           '\r\n         `                           '\r\n        `                           `\r\n        `                           `,\r\n        `\r\n         `\r\n           `.");
                Console.ResetColor();
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win! Congratulations!");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("Press any key to close the game...");
                Console.ReadKey();
                Environment.Exit(0);
            } else if (counter1 != 0 && counter2 != 0 && counter3 != 0 && respect < 40)
            {
                Console.WriteLine("He looks back at you with disgust");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("");
                Console.WriteLine("You have completed all of my quests, but you have low respect. I hope you're happy with yourself.");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("You 'win', although no one in the town likes you. You might wanna work on that.");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("Press any key to close the game...");
                Console.ReadKey();
                Environment.Exit(0);
            } else
            {
                Console.WriteLine("He looks back at you with rage filled eyes.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("HOW DARE YOU DISOBEY ME! I'LL KILL YOU!");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("The Quest Master charges at you and impales you with a trident, killing you immediately.");
                Console.WriteLine("");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose! Better luck next time.");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("Press any key to close the game...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}

