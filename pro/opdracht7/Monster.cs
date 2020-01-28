using System;

namespace opdracht5
{
    public class Monster
    {
        private int _monsterHealth;
        private int _monsterScore;
        private string _name;

        private int _monsterLives;
        private bool _isDead;
        public bool isDead
        {
            get
            {
                return _isDead;
            }
        }


        public string name
        {
            set
            {
                bool fail = false;
                foreach (char c in value)
                {
                    if (Char.IsDigit(c))
                    {
                        Console.WriteLine("invalid input");
                        fail = true;
                    }
                    string[] args = value.Split(" ");
                    if (args.Length > 3)
                    {
                        Console.WriteLine("invalid input");
                        fail = true;
                    }
                }
                if (!fail)
                {
                    _name = value;
                }
            }
            get
            {
                return _name;
            }
        }

        public int monsterHealth
        {
            set
            {
                if (value > 0 && value < 99)
                {
                    _monsterHealth = value;
                }
                else
                {
                    _monsterHealth = 0;
                }
                if (_monsterHealth == 0)
                {
                    _isDead = true;
                }
            }
            get
            {
                return _monsterHealth;
            }
        }

        public int monsterScore
        {
            set
            {
                if (value > 0 && value < 99)
                {
                    _monsterScore = value;
                }
                else
                {
                    _monsterScore = 0;
                }
            }
            get
            {
                return _monsterScore;
            }
        }
    }
}
