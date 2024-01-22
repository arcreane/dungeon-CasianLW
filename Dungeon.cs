using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DungeonPlace
{
    public Room[] m_RoomArray { get; private set; }

    private int m_iRoomIndex;
    public DungeonPlace()
    {
        m_RoomArray = new Room[5];
        m_iRoomIndex = 0;

        // Initialize each room
        for (int i = 0; i < m_RoomArray.Length; i++)
        {
            m_RoomArray[i] = new Room();
        }
    }

   



    /// <summary>
    /// @param p_Hero 
    /// @return
    /// </summary>
    public void Explore(Hero p_Hero)
    {
        // TODO implement here
        while (p_Hero.LifePoints > 0 && m_iRoomIndex < m_RoomArray.Length)
        {
            Monster monster = m_RoomArray[m_iRoomIndex].OpenDoor(p_Hero);

            if (monster != null)
            {
                // Handle the encounter with the monster
                // This could involve combat or other interactions
            }
            else
            {
                // No monster in the room, move to the next one
                m_iRoomIndex++;
            }
        }


        //while (p_Hero.m_iLifePoints != 0)
        //{
        //    m_RoomArray[m_iRoomIndex].OpenDoor(p_Hero);
        //}

    }

}
