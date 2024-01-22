
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Fire
{
    public Weapon BaseWeapon { get; private set; }

    public Fire()
    {
        BaseWeapon = new Weapon("Fire", 15, 30, true, 0);
    }
}