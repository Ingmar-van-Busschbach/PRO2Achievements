using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;

namespace quizEngine
{
    class Program
    {

        private static int score = 0;
        static void Main(string[] args)
        {
            //generate a random number for random question lists 1, 2 or 3
            Random rnd = new Random();
            int index2 = rnd.Next(1, 4);

            //create questions and answers            
            List<Question> questions = CreateQuestions();
            List<Question2> questions2 = CreateQuestions2();
            List<Question3> questions3 = CreateQuestions3();

            Console.ForegroundColor = ConsoleColor.White;

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkYellow;

            //if random number is 3, show list A. if 2, show B. else show C
            int i = 0;
            if (index2 > 2)
            {
                //list A, "questions"
                foreach (Question q in questions)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Score : " + score);
                    Console.WriteLine("Question seed:" + index2);

                    i++;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("question " + i + ": " + q.GetString());
                    int j = 0;
                    foreach (Answer a in q.GetOptions())
                    {
                        j++;
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Type  " + j + " for : " + a.GetString());
                    }

                    //Await player input and validate if it's an int
                    int input;
                    bool parsed = false;
                    do
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Please answer with a number");
                        parsed = int.TryParse(Console.ReadLine(), out input);
                    }
                    while (!parsed);

                    int result = q.AnswerIt(input - 1);//returns -1 if wrong

                    if (result > -1)
                    {//RIGHT
                        score += result;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Correct Answer!");
                        Console.WriteLine("+" + result);
                        Console.Beep(1500, 100);
                        Console.Beep(2000, 100);
                        Console.Beep(2500, 100);
                        Thread.Sleep(1700);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                    {//WRONG
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("That was the wrong asnwer.");
                        Console.Beep(700, 1000);
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
                //After questions are answered player enters name for highscore
                Console.Clear();
                Console.WriteLine("Game Over your score is : " + score + " points");
                Console.WriteLine("Please enter your name:");
                string playerName = Console.ReadLine();
                HighScore.WriteHighScore(playerName, score, "highScore.txt");


                //print highscore after highscore is saved
                string[] highScore = ListSorter.GetSortedHighScore("highScore.txt");

                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("+-----------+ Highscore +-----------+");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                int count = highScore.Length;
                if (count > 10) count = 10;
                for (int k = 0; k < count; k++)
                {
                    Console.WriteLine(highScore[k]);
                }
            }
            else
            {
                //list B, "questions2"
                if (index2 > 1)
                {
                    foreach (Question2 q in questions2)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Score : " + score);
                        Console.WriteLine("Possible:" + index2);
                        i++;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("question " + i + ": " + q.GetString());
                        int j = 0;
                        foreach (Answer2 a in q.GetOptions2())
                        {
                            j++;
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Type  " + j + " for : " + a.GetString());
                        }

                        //Await player input and validate if it's an int
                        int input;
                        bool parsed = false;
                        do
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Please answer with a number");
                            parsed = int.TryParse(Console.ReadLine(), out input);
                        }
                        while (!parsed);

                        int result = q.AnswerIt2(input - 1);//returns -1 if wrong

                        if (result > -1)
                        {//RIGHT
                            score += result;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Correct Answer!");
                            Console.WriteLine("+" + result);
                            Console.Beep(1500, 100);
                            Console.Beep(2000, 100);
                            Console.Beep(2500, 100);
                            Thread.Sleep(1700);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        else
                        {//WRONG
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("That was the wrong asnwer.");
                            Console.Beep(700, 1000);
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                    }
                    //After questions are answered player enters name for highscore
                    Console.Clear();
                    Console.WriteLine("Game Over your score is : " + score + " points");
                    Console.WriteLine("Please enter your name:");
                    string playerName = Console.ReadLine();
                    HighScore.WriteHighScore(playerName, score, "highScore.txt");


                    //print highscore after highscore is saved
                    string[] highScore = ListSorter.GetSortedHighScore("highScore.txt");

                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("+-----------+ Highscore +-----------+");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    int count = highScore.Length;
                    if (count > 10) count = 10;
                    for (int k = 0; k < count; k++)
                    {
                        Console.WriteLine(highScore[k]);
                    }
                }
                else
                {
                    //list C, "questions3"
                    foreach (Question3 q in questions3)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Score : " + score);
                        Console.WriteLine("Possible:" + index2);
                        i++;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("question " + i + ": " + q.GetString());
                        int j = 0;
                        foreach (Answer3 a in q.GetOptions3())
                        {
                            j++;
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Type  " + j + " for : " + a.GetString());
                        }

                        //Await player input and validate if it's an int
                        int input;
                        bool parsed = false;
                        do
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Please answer with a number");
                            parsed = int.TryParse(Console.ReadLine(), out input);
                        }
                        while (!parsed);

                        int result = q.AnswerIt3(input - 1);//returns -1 if wrong

                        if (result > -1)
                        {//RIGHT
                            score += result;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Correct Answer!");
                            Console.WriteLine("+" + result);
                            Console.Beep(1500, 100);
                            Console.Beep(2000, 100);
                            Console.Beep(2500, 100);
                            Thread.Sleep(1700);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        else
                        {//WRONG
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("That was the wrong asnwer.");
                            Console.Beep(700, 1000);
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                    }
                    //After questions are answered player enters name for highscore
                    Console.Clear();
                    Console.WriteLine("Game Over your score is : " + score + " points");
                    Console.WriteLine("Please enter your name:");
                    string playerName = Console.ReadLine();
                    HighScore.WriteHighScore(playerName, score, "highScore.txt");


                    //print highscore after highscore is saved
                    string[] highScore = ListSorter.GetSortedHighScore("highScore.txt");

                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("+-----------+ Highscore +-----------+");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    int count = highScore.Length;
                    if (count > 10) count = 10;
                    for (int k = 0; k < count; k++)
                    {
                        Console.WriteLine(highScore[k]);
                    }
                }
            }
        }

        //questions for list A
        static List<Question> CreateQuestions()
        {
            return new List<Question>{

                new Question("Bohemian Rhapsody was written by which band/performer?",
                25,
                new List<Answer>{
                    new Answer("Michael Jackson"),
                    new Answer("Queen"),
                    new Answer("The Beatles")
                    },
                1),
                new Question("How did Michael Jackson die?",
                50,
                new List<Answer>{
                    new Answer("An overdose of morphine"),
                    new Answer("The Sherrif shot him"),
                    new Answer("He got hit by a train"),
                    new Answer("The Maffia threw him in a river")
                    },
                0),
                new Question("Which of the following songs is NOT written by The Rolling Stones",
                50,
                new List<Answer>{
                    new Answer("Paint it Black"),
                    new Answer("Honky Tonk Women"),
                    new Answer("It's only Rock 'n Roll"),
                    new Answer("Ob-La-Di, Ob-La-Da"),
                    },
                3),
                new Question("In what year did The Beatles release their first album?",
                50,
                new List<Answer>{
                    new Answer("1959"),
                    new Answer("1960"),
                    new Answer("1961"),
                    new Answer("1962")
                    },
                2),
                new Question("Fill in the missing word in the title of this Queen song: We will ___ you",
                25,
                new List<Answer>{
                    new Answer("Hurt"),
                    new Answer("Rock"),
                    new Answer("Entertain"),
                    },
                1),
                new Question("Which band made a song about living in a submarine?",
                75,
                new List<Answer>{
                    new Answer("The Rolling Stones"),
                    new Answer("The Beatles"),
                    new Answer("Queen"),
                    },
                1),
                new Question("'No Woman, No Cry' was a real 80s hit. Who wrote it?",
                75,
                new List<Answer>{
                    new Answer("Michael Jackson"),
                    new Answer("Bob Marley"),
                    new Answer("Elvis Presley"),
                    },
                1),
                new Question("Who was called 'The King of Rock and Roll'?",
                50,
                new List<Answer>
                {
                    new Answer("Elvis Presley"),
                    new Answer("Michael Jackson"),
                    new Answer("Bob Marley")
                },
                2),
                new Question("Who wrote the song 'The final Countdown'?",
                100,
                new List<Answer>{
                    new Answer("Joey Tempest"),
                    new Answer("Europe"),
                    new Answer("Bob Marley"),
                    new Answer("Michael Jackson"),
                },
                0),
                new Question("Who was called 'The King of Pop'?",
                50,
                new List<Answer>
                {
                    new Answer("Michael Jackson"),
                    new Answer("Elvis Presley"),
                    new Answer("Bob Marley")
                },
                0),
            };

        }

        //questions for list B
        static List<Question2> CreateQuestions2()
        {
            return new List<Question2>{

                new Question2("Who was called 'The King of Pop'?",
                50,
                new List<Answer2>
                {
                    new Answer2("Michael Jackson"),
                    new Answer2("Elvis Presley"),
                    new Answer2("Bob Marley")
                },
                0),
                new Question2("Fill in the missing word in the title of this Queen song: We will ___ you",
                25,
                new List<Answer2>{
                    new Answer2("Hurt"),
                    new Answer2("Rock"),
                    new Answer2("Entertain"),
                    },
                1),
                new Question2("Who wrote the song 'The final Countdown'?",
                100,
                new List<Answer2>{
                    new Answer2("Europe"),
                    new Answer2("Bob Marley"),
                    new Answer2("Joey Tempest"),
                    new Answer2("Michael Jackson"),
                },
                2),
                new Question2("Which of the following songs is NOT written by The Rolling Stones",
                50,
                new List<Answer2>{
                    new Answer2("Paint it Black"),
                    new Answer2("Honky Tonk Women"),
                    new Answer2("It's only Rock 'n Roll"),
                    new Answer2("Ob-La-Di, Ob-La-Da"),
                    },
                3),
                new Question2("Who was called 'The King of Rock and Roll'?",
                50,
                new List<Answer2>
                {
                    new Answer2("Elvis Presley"),
                    new Answer2("Michael Jackson"),
                    new Answer2("Bob Marley")
                },
                2),
                new Question2("Bohemian Rhapsody was written by which band/performer?",
                25,
                new List<Answer2>{
                    new Answer2("Michael Jackson"),
                    new Answer2("Queen"),
                    new Answer2("The Beatles")
                    },
                1),
                new Question2("'No Woman, No Cry' was a real 80s hit. Who wrote it?",
                75,
                new List<Answer2>{
                    new Answer2("Michael Jackson"),
                    new Answer2("Bob Marley"),
                    new Answer2("Elvis Presley"),
                    },
                1),
                new Question2("In what year did The Beatles release their first album?",
                50,
                new List<Answer2>{
                    new Answer2("1959"),
                    new Answer2("1960"),
                    new Answer2("1961"),
                    new Answer2("1962")
                    },
                2),
                new Question2("How did Michael Jackson die?",
                50,
                new List<Answer2>{
                    new Answer2("He got shot"),
                    new Answer2("He got hit by a train"),
                    new Answer2("The Maffia threw him in a river"),
                    new Answer2("An overdose of morphine"),
                    },
                3),
                new Question2("Which band made a song about living in a submarine?",
                75,
                new List<Answer2>{
                    new Answer2("The Rolling Stones"),
                    new Answer2("The Beatles"),
                    new Answer2("Queen"),
                    },
                1),
            };

        }

        //questions for list C
        static List<Question3> CreateQuestions3()
        {
            return new List<Question3>
            {

                new Question3("Which band made a song about living in a submarine?",
                75,
                new List<Answer3>
                {
                    new Answer3("The Rolling Stones"),
                    new Answer3("The Beatles"),
                    new Answer3("Queen"),
                },
                1),
                new Question3("Which of the following songs is NOT written by The Rolling Stones",
                50,
                new List<Answer3>{
                    new Answer3("Paint it Black"),
                    new Answer3("Honky Tonk Women"),
                    new Answer3("It's only Rock 'n Roll"),
                    new Answer3("Ob-La-Di, Ob-La-Da"),
                    },
                3),
                new Question3("'No Woman, No Cry' was a real 80s hit. Who wrote it?",
                75,
                new List<Answer3>
                {
                    new Answer3("Michael Jackson"),
                    new Answer3("Bob Marley"),
                    new Answer3("Elvis Presley"),
                },
                1),
                new Question3("Who was called 'The King of Pop'?",
                50,
                new List<Answer3>
                {
                    new Answer3("Michael Jackson"),
                    new Answer3("Elvis Presley"),
                    new Answer3("Bob Marley")
                },
                0),
                new Question3("Bohemian Rhapsody was written by which band/performer?",
                25,
                new List<Answer3>{
                    new Answer3("Queen"),
                    new Answer3("Michael Jackson"),
                    new Answer3("The Beatles")
                    },
                0),
                new Question3("Who wrote the song 'The final Countdown'?",
                100,
                new List<Answer3>{
                    new Answer3("Joey Tempest"),
                    new Answer3("Europe"),
                    new Answer3("Bob Marley"),
                    new Answer3("Michael Jackson"),
                },
                0),
                new Question3("Fill in the missing word in the title of this Queen song: We will ___ you",
                25,
                new List<Answer3>
                {
                    new Answer3("Entertain"),
                    new Answer3("Hurt"),
                    new Answer3("Rock"),
                },
                2),
                new Question3("Who was called 'The King of Rock and Roll'?",
                50,
                new List<Answer3>
                {

                    new Answer3("Michael Jackson"),
                    new Answer3("Bob Marley"),
                    new Answer3("Elvis Presley"),
                },
                1),
                new Question3("How did Michael Jackson die?",
                50,
                new List<Answer3>{
                    new Answer3("The Sherrif shot him"),
                    new Answer3("He got hit by a train"),
                    new Answer3("An overdose of morphine"),
                    new Answer3("The Maffia threw him in a river")
                    },
                2),
                new Question3("In what year did The Beatles release their first album?",
                50,
                new List<Answer3>{
                    new Answer3("1959"),
                    new Answer3("1960"),
                    new Answer3("1961"),
                    new Answer3("1962")
                    },
                2),
            };
        }
    }
}
