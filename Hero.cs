
using DungeonGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Hero {
    public HashSet<Protection> Protections { get; private set; }
    public Arsenal HeroArsenal { get; set; }
    public int LifePoints { get; set; }
    public Weapon ActiveWeapon { get; set; }
    public Shield ActiveShield { get; set; }

    public int Strength { get; set; }
    public int Defense { get; set; }




    public Hero() {
        Protections = new HashSet<Protection>();
        HeroArsenal = new Arsenal();
        LifePoints = 100; // Initial life points, this value might be different in your game
        ActiveWeapon = new Weapon("Fists", 1, 100, false, 0);
        ActiveShield = new Shield(); // Default shield
        Strength = 100;
        Defense = 100;



    }

    public void SelectProtection() {
        // TODO implement here
        // Example logic: Select a random protection if available
        if (Protections.Count > 0)
        {
            var random = new Random();
            //ActiveWeapon = Protections.ElementAt(random.Next(Protections.Count));
            var protection = Protections.ElementAt(random.Next(Protections.Count));
            // Assume Protection has a related weapon for simplification.
            ActiveWeapon = protection.Weapon;
        }
    }

    /// <summary>
    /// @param RoomMonster
    /// </summary>
    public void AutoSelectCorrectProtection(Monster RoomMonster) {
        // TODO implement here
        foreach (var protection in Protections)
        {
            if (protection.CheckEfficiency(RoomMonster))
            {
                ActiveWeapon = protection.Weapon;
                break;
            }
        }
    }

    /// <summary>
    /// @param p_Monster 
    /// @return
    /// </summary>
    public void Attack(Monster p_Monster) {
        // TODO implement here
        if (!ActiveWeapon.Equals(default(Weapon)))

            {
                p_Monster.ReceiveDamage(ActiveWeapon.Damage);
        }
    }

    /// <summary>
    /// @param p_Monster
    /// </summary>
    public void CheckProtectionEfficiency(Monster p_Monster) {
        // TODO implement here
        if (!ActiveWeapon.Equals(default(Weapon)) && !ActiveWeapon.IsEffectiveAgainst(p_Monster))
        {
            // Change weapon or alert the player
            SelectProtection();
        }
    }

    public void GettingHit(int damage)
    {
        // Subtract damage from life points, considering active protection
        int damageToTake = damage;

            if (!ActiveWeapon.Equals(default(Weapon)))

            {
                damageToTake -= ActiveWeapon.ProtectionValue;
            // Assume that Weapon has a property that mitigates incoming damage
            ActiveShield.BlockAttack(); // Shield durability reduces when blocking an attack

        }

        LifePoints -= damageToTake;

        if (LifePoints <= 0)
        {
            Console.WriteLine("The hero has fallen!");
        }
    }

    public void OpenChest(Chest chest)
    {
        var items = chest.Open();
        foreach (var item in items)
        {
            if (item is Weapon weapon)
            {
                HeroArsenal.AddWeapon(weapon);
            }
            else if (item is Protection protection)
            {
                Protections.Add(protection);
            }
            else if (item is Potion potion)
            {
                ConsumePotion(potion); // Assuming Potion has a Consume method
            }
        }
    }

    // Method for the hero to consume a potion directly
    public void ConsumePotion(Potion potion)
    {
        potion.Consume(this); // Affect the Hero based on the potion type and potency
    }
}