
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class IceArrow
{
    public Weapon BaseWeapon { get; private set; }

    public IceArrow()
    {
        BaseWeapon = new Weapon("Ice Arrow", 7, 20, true, 0);
    }
}