using System;
using System.Collections.Generic;

namespace Calculator
{
    public class PlayCharacter
    {
        public int Health { get; set; }
        public bool IsNoob { get; set; }
        public string NickName { get; set; }
        public string Name { get; }
        public List<string> Weapons { get; set; }
        public PlayCharacter()
        {
            Name = GenerateName();
            IsNoob = true;
            CreateStartingWeapons();
        }

        private void CreateStartingWeapons()
        {
            Weapons = new List<string>
            {
                "Long Bow",
                "Short Bow",
                "Short Sword",
                ""
                // "Long Bow",
                // "Staff Of Wonder"
            };
        }

        private static string GenerateName()
        {
            var names = new[]
            {
                "Danieth",
                "Derick",
                "Shalnorr",
                "G'Toth'lop",
                "Boldrakteethtop"
            };
            return names[new Random().Next(0, names.Length)];
        }

        public void Sleep()
        {
            var rnd = new Random();
            var healthIncrease = rnd.Next(1, 101);
            Health += healthIncrease;
        }

        public void TakeDamage(int damage)
        {
            Health = Math.Max(1, Health -= damage);
        }
    }
}
