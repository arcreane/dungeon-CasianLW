
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Claw
{
    public Weapon BaseWeapon { get; private set; }

    public Claw()
    {
        BaseWeapon = new Weapon("Claw", 8, 100, false, 2);
    }
}