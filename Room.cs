
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Room {
    private Random randomGenerator;


    public Room() {
        randomGenerator = new Random();

    }




    /// <summary>
    /// @param p_Hero 
    /// @return
    /// </summary>
    /// 
    //  50% chance to meet a monster in the room
    public Monster OpenDoor(Hero p_Hero) {
        p_Hero.SelectProtection();

        bool hasMonster = randomGenerator.NextDouble() < 0.5;

        if (hasMonster)
        {
            
            return new Monster(); 
        }

        return null; 
        }

    }