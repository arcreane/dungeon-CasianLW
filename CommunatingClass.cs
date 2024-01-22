using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    public delegate void GetPlayerAction(string action);
    public delegate void InformPlayer(string message);

    public class CommunicatingClass
    {
        public GetPlayerAction OnGetPlayerAction;
        public InformPlayer OnInformPlayer;

        // Changez 'protected' en 'public' pour permettre l'accès depuis l'extérieur et vice versa
        public void RequestPlayerAction()
        {
            OnGetPlayerAction?.Invoke("ActionRequested");
        }

        public void SendInfoToPlayer(string message)
        {
            OnInformPlayer?.Invoke(message);
        }
    }

}
