using System;

namespace opdracht5
{
    public class Person
    {
        private string eyeColor;
        private double size;
        private int age;
        private string name;
        private string birthLand;
        private double bsn;
        private int index;


            public void SetName(string inName)
            {
                bool fail = false;
                foreach (char c in inName)
                {
                    if (Char.IsDigit(c))
                    {
                    Console.WriteLine("invalid input");
                    fail = true;
                    }
                    string[] args = inName.Split(" ");
                    if (args.Length > 3)
                    {
                    Console.WriteLine("invalid input");
                    fail = true;
                    }
                }
            if(!fail)
            {
                name = inName;
            }
            }

            public string GetName()
        {
            return name;
        }



            public void SetColor(string eyeColor)
            {
                if (eyeColor == "blue" || eyeColor == "grey" || eyeColor == "brown" || eyeColor == "green")
                    {
                        string personColor = eyeColor;
                    }
                else
                    {
                Console.WriteLine("invalid input");
            }
            }
            


        public void SetSize(double size)
        {
            if (size < 2.20 && size > 1.00)
            {
                double personSize = size;
            }
            else
            {
                double personSize = 0;
            }
        }



        public void SetAge(int age)
        {
            if (age > 7 && age < 99)
            {
                int personAge = age;
            }
            else
            {
                int personAge = 0;
            }
        }



        public void SetBSN(double bsn)
        {
            double bsnTemp = Math.Floor(Math.Log10(bsn) + 1);
            if (bsnTemp != 9)
            {
                bsn = 0;
            }
        }


            public void SetCountry(string country)
            {
                foreach (string c in CountryList.LIST)
                {
                    if (c == country)
                    {
                    }
                    else
                    {
                        country = "invalid country";
                    }
                }
            }
    }
}
