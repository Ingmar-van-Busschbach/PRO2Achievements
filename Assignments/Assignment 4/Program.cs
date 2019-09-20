﻿using System;
using System.Collections;
using System.Collections.Generic;
namespace HangMan_Game
{
    class Program
    {
        static ArrayList wordsArray = new ArrayList();
        static ArrayList wordChars = new ArrayList();
        static ArrayList Progress = new ArrayList();

        static List<string> givenLetters = new List<string>();

        static int livesLeft;
        static int wrongLetters = 0;
        static int currentWord = 0;
        static int correctChecker = 0;
        static int correctChars = 0;
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("###################################################################");
            Console.WriteLine("#                           HANG MAN  FORKED                      #");
            Console.WriteLine("#                     PRESS ANY KEY AND ENTER                     #");
            Console.WriteLine("###################################################################");
            livesLeft = 5;
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("########################################");
            Console.WriteLine("()  Type --  StopGame  -- om de game te stoppen");
            Console.WriteLine("########################################");
            Console.WriteLine("()  Het typen van het heleword is niet mogelijk en word als fout antwoord gezien\nDit betekend dus dat je maar 1 letter per keer mag type");
            Console.WriteLine("########################################");
            Console.WriteLine("()  Alle letters moeten in kleineletters - GEEN hoofdletters dus");
            Console.WriteLine("########################################");

            Console.WriteLine("Dit bericht verwijnd over 1 seconde");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            givenLetters.Clear();

            //Lees alle lines uit het opgegeven txt bestand
            string[] wordsFile = System.IO.File.ReadAllLines(@"C:\Users\Gebruiker\Documents\GitHub\PRO2Achievements\Assignments\Assignment 4\Words.txt");

            //Voor elke Line in de words file add it to an message array.
            foreach (string line in wordsFile)
            {
                // Use a tab to indent each line of the file.
                wordsArray.Add(line);
            }

            var Random = new Random();
            var Number = Random.Next(0, 66);
            char[] theWord = wordsFile[Number].ToCharArray();
            var TheWord = wordsArray[Number].ToString();

            //Voor elke letter in het word voeg een . toe aan progress
            //en voegt voor elk letter in het word ook de letter toe aan de wordChars array 

            foreach (char c in theWord)
            {
                var stringLetter = c.ToString();
                wordChars.Add(stringLetter);
                Progress.Add(".");
            }
            while (livesLeft != 0)
            {

                Console.WriteLine("-----HANG MAN-----");
                //Stuur het progress van de speler
                foreach (var item in Progress)
                {
                    Console.Write(item);
                }
                if (givenLetters.Count != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Foute letters:");
                    var combined = string.Join(", ", givenLetters);
                    Console.WriteLine(combined);
                }
                Console.WriteLine();
                Console.WriteLine("- Jouw levens: " + livesLeft);
                Console.WriteLine("- Enter a letter");
                var enteredLetter = Console.ReadLine();
                var EnterWordString = enteredLetter.ToString();
                int enterlenght = enteredLetter.Length;
                //Als de speler stopgame typed stop de game
                if (enteredLetter.Equals("StopGame"))
                {
                    Console.Clear();
                    Console.WriteLine("De game is gestopt");
                    return;
                }
                if (enterlenght == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Geef wel een letter mee.");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                }
                else if (enterlenght != 1)
                {
                    Console.Clear();
                    Console.WriteLine("Stuur maar 1 letter per keer mee!");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                }
                else if (givenLetters.Contains(enteredLetter))
                {
                    Console.WriteLine("Het opgegeven letter is al eerder ingevoert let wel op he!");
                }


                enteredLetter.ToString().ToCharArray();
                foreach (String s in wordChars)
                {
                    if (enteredLetter == s)
                    {
                        Progress[currentWord] = s;
                        currentWord++;
                    }
                    else
                    {
                        wrongLetters++;
                        currentWord++;
                    }
                }

                //Correct checker na de laatste letter, zodat hij pas checked na je antwoord
                foreach (String s in wordChars)
                {
                    if (Progress[correctChars] == wordChars[correctChars])
                    {
                        correctChars++;
                        correctChecker++;
                    }
                    else
                    {
                        correctChecker++;
                    }
                }
                if (correctChars == wordChars.Count)
                {
                    setAllNull();
                    Console.Clear();
                    Console.WriteLine("Het helewoord is goed. goed gedaan. het woord was:\n" + TheWord);
                    Console.WriteLine("\n\nDruk op enter om de game te sluiten");
                    Console.ReadLine();
                    return;
                }


                //zet alle nummers weer naar 0
                if (enterlenght == 0)
                {
                    //Deze zijn hier puur zodat het niet de rest kan doen
                    //reset de int weer tegen out of bound exeption
                    setAllNull();
                }
                else if (enterlenght != 1 && enterlenght != 0)
                {
                    //Deze zijn hier puur zodat het niet de rest kan doen

                    //reset de int weer tegen out of bound exeption
                    setAllNull();
                }
                else if (givenLetters.Contains(enteredLetter))
                {
                    setAllNull();
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
                else if (wrongLetters == wordChars.Count)
                {
                    Console.WriteLine("Het was fout");
                    givenLetters.Add(enteredLetter);
                    livesLeft--;
                    System.Threading.Thread.Sleep(2000);
                    setAllNull();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Het was goed");
                    System.Threading.Thread.Sleep(2000);
                    setAllNull();
                    Console.Clear();
                }
            }

            if (livesLeft == 0)
            {
                Console.WriteLine("Je levens zijn op. Jammer dat je het niet gehaald hebt, het juiste woord was:\n" + TheWord);
                Console.WriteLine("\n\nDruk op enter om de game te stoppen");
                Console.ReadLine();
            }
        }
        static void setAllNull()
        {
            currentWord = 0;
            wrongLetters = 0;
            correctChecker = 0;
            correctChars = 0;
        }
    }
}