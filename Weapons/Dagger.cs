
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Dagger
{
    public Weapon BaseWeapon { get; private set; }

    public Dagger()
    {
        BaseWeapon = new Weapon("Dagger", 6, 80, false, 0);
    }
}