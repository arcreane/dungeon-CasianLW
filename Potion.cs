using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    public enum PotionType
    {
        Health,
        Strength,
        Defense
    }

    public class Potion:Item
    {
        public PotionType Type { get; set; }
        public int Potency { get; set; } // How strong the potion's effect is

        public Potion(PotionType type, int potency)
        {
            Type = type;
            Potency = potency;
        }

        public void Consume(Hero hero)
        {
            switch (Type)
            {
                case PotionType.Health:
                    hero.LifePoints += Potency;
                    break;
                case PotionType.Strength:
                    // Assume hero has a strength property or similar
                    hero.Strength += Potency;
                    break;
                case PotionType.Defense:
                    // Assume hero has a defense property or similar
                    hero.Defense += Potency;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

}
