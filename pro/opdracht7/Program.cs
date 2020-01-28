using System;

namespace opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool monsterFound = false;
            int score = 0;

            Monster[] monsterArray = new Monster[5];
            monsterArray[0]= new Monster();
            monsterArray[1] = new Monster();
            monsterArray[2] = new Monster();
            monsterArray[3] = new Monster();
            monsterArray[4] = new Monster();

            monsterArray[0].name = "Apple";
            monsterArray[1].name = "Banana";
            monsterArray[2].name = "Coconut";
            monsterArray[3].name = "Donut";
            monsterArray[4].name = "Eggplant";

            monsterArray[0].monsterHealth = 1;
            monsterArray[1].monsterHealth = 1;
            monsterArray[2].monsterHealth = 1;
            monsterArray[3].monsterHealth = 1;
            monsterArray[4].monsterHealth = 1;

            monsterArray[0].monsterScore = 1;
            monsterArray[1].monsterScore = 2;
            monsterArray[2].monsterScore = 3;
            monsterArray[3].monsterScore = 4;
            monsterArray[4].monsterScore = 5;

            while (monsterArray[0].isDead == false || monsterArray[1].isDead == false || monsterArray[2].isDead == false || monsterArray[3].isDead == false || monsterArray[4].isDead == false) {
                string input = Console.ReadLine();
                string[] inputArgs = input.Split(" ");
                if (inputArgs.Length > 2)
                {
                    Console.WriteLine("Error! More than 2 arguments found!");
                }
                else
                {
                    if (inputArgs[0] == "attack")
                    {
                        monsterFound = false;
                        for (int index = 0; index < monsterArray.Length; index++)
                        {
                            if (inputArgs[1] == monsterArray[index].name && monsterArray[index].isDead == false)
                            {
                                monsterArray[index].monsterHealth = monsterArray[index].monsterHealth - 1;
                                Console.WriteLine("Success! {0}'s health is {1}", monsterArray[index].name, monsterArray[index].monsterHealth);
                                if (monsterArray[index].monsterHealth == 0)
                                {
                                    Console.WriteLine("{0} died!", monsterArray[index].name);
                                    score = score + monsterArray[index].monsterScore;
                                    Console.WriteLine("Your score is now {0}!", score);
                                }
                                monsterFound = true;
                                break;
                            }
                        }
                        if (monsterFound == false)
                        {
                            Console.WriteLine("Error! No monster found with that name!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error! Input was not attack!");
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("                      ___________");
            Console.WriteLine("                 .---'::'        `---.");
            Console.WriteLine("                (::::::'              )");
            Console.WriteLine("                |`-----._______.---- - '|");
            Console.WriteLine("                |              :::::::| ");
            Console.WriteLine("               .|               ::::::! -.");
            Console.WriteLine("                |               :::::/|/ ");
            Console.WriteLine("                |               ::::::| ");
            Console.WriteLine("                |  Special EPIC Award:| ");
            Console.WriteLine("                |     for Epicness::::| ");
            Console.WriteLine("                |               ::::::| ");
            Console.WriteLine("                |              .::::::| ");
            Console.WriteLine("                J              :::::::F");
            Console.WriteLine("                 {            :::::::/ ");
            Console.WriteLine("                  `.        .:::::::'");
            Console.WriteLine("                    `-._.::::::- '");
            Console.WriteLine("________________________| ;;; |;_________________________________________");
            Console.WriteLine("                        |  :::| ");
            Console.WriteLine("                        F   ::J ");
            Console.WriteLine("                       /     ::} ");                                        
            Console.WriteLine("                  __.- '      :::`-.__");
            Console.WriteLine("                 (_            ::::::_)");
            Console.WriteLine("                   `'''---------''''' ");
            Console.WriteLine("Press any button to exit, you EPIC madman");
            Console.ReadKey();
        }
    }
}
