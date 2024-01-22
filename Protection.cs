
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Protection:Item {
    public Weapon Weapon { get; set; }

    public Protection() 
    {
        Weapon = new Weapon("Default Weapon", 5, 100, false, 2);
    }


    /// <summary>
    /// @param MonsterInRoom 
    /// @return
    /// </summary>
    public bool CheckEfficiency(Monster MonsterInRoom) {
        // TODO implement here
        //return false;
        return Weapon != null && Weapon.IsEffectiveAgainst(MonsterInRoom);

        //return Weapon.IsEffectiveAgainst(MonsterInRoom);
    }

}