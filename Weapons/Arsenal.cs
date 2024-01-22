
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Arsenal
{
    public HashSet<Weapon> Weapons { get; private set; }

    public Arsenal()
    {
        Weapons = new HashSet<Weapon>();
    }

    public void AddWeapon(Weapon weapon)
    {
        Weapons.Add(weapon);
    }
}