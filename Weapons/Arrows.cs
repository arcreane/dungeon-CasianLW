
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Arrows
{
    public Weapon BaseWeapon { get; private set; }

    public Arrows()
    {
        BaseWeapon = new Weapon("Arrows", 4, 40, false, 0);
    }
}