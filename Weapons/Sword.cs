
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Sword {
    public Weapon BaseWeapon { get; private set; }


    public Sword() {
        BaseWeapon = new Weapon("Sword", 10, 100, false, 0);

    }

}