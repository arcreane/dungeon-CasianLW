
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Weapon:Item {
    public int Damage { get; set; }
    public int Durability { get; set; }
    public bool IsMagical { get; set; }
    public int ProtectionValue { get; set; }

    public Weapon(string name, int damage, int durability, bool isMagical, int protectionValue)
    {
        Name = name;
        Damage = damage;
        Durability = durability;
        IsMagical = isMagical;
        ProtectionValue = protectionValue;
    }
    public void Hit()
    {
        if (Durability > 0)
        {
            Durability--;
        }
        else
        {
            // The weapon is broken and cannot be used until repaired
        }
    }
    public bool IsEffectiveAgainst(Monster monster)
    {
        // Logic to determine if the weapon is effective against the monster
        // This could involve checking if the monster is vulnerable to magical attacks for example
        if (IsMagical && monster.HasMagicalWeakness)
        {
            return true;
        }
        return false;
    }

    public void Repair()
    {
        // Assuming there is a maximum durability that a weapon can have
        Durability = 100;
    }



}