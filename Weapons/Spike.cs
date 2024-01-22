
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Spike
{
    public Weapon BaseWeapon { get; private set; }

    public Spike()
    {
        BaseWeapon = new Weapon("Spike", 5, 50, false, 1);
    }
}