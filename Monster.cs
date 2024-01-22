
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Monster {
    public int LifePoints { get; set; }
    public Weapon Weapon { get; set; }
    public Weapon EfficientWeapon { get; set; }
    public bool HasMagicalWeakness { get; set; }


    public Monster() {
        LifePoints = 50; // Default life points for the monster
        Weapon = new Weapon("Claws", 10, 100, false, 0);
        EfficientWeapon = new Weapon("Fire Breath", 20, 50, true, 5);
        HasMagicalWeakness = false;
    }

    public int m_iLifePoints;

    public Weapon m_Weapon;

    public Weapon m_EfficientWeapon;



    /// <summary>
    /// @param p_Hero 
    /// @return
    /// </summary>
    public void Attack(Hero p_Hero) {
        // TODO implement here
        p_Hero.GettingHit(Weapon.Damage);

    }
    public void ReceiveDamage(int damage)
    {
        // Monster receives damage from an attack
        LifePoints -= damage;
        if (LifePoints <= 0)
        {
            // Handle the monster's death
        }
    }

}