using System;

namespace opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {

            Person[] playerArray = new Person[5];
            playerArray[0]= new Person();
            playerArray[1] = new Person();
            playerArray[2] = new Person();
            playerArray[3] = new Person();
            playerArray[4] = new Person();


            playerArray[0].SetColor("blue");
            playerArray[0].SetSize(2.00);
            playerArray[0].SetAge(20);
            playerArray[0].SetName("Chantal Walfort");
            playerArray[0].SetCountry("Germany");
            playerArray[0].SetBSN(193683059);

            Console.WriteLine("-----");
                for (int i = 0; i < playerArray.Length; i++)
                {
                    Console.WriteLine(playerArray[i].GetName());
                }
            Console.WriteLine("-----\n");
        }
    }
}
