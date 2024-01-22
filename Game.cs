using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Game {

    public Game() {
        HeroPlayer = new Hero();
        GameDungeon = new DungeonPlace();
        Initialise();

    }

    public Hero HeroPlayer;

    public DungeonPlace GameDungeon;




    public void Initialise() {
        // TODO implement here
    }

}