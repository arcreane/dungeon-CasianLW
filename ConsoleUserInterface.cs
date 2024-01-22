using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{


    public interface IUserInterface
    {
        void Display(string message);
    }

    public class ConsoleUserInterface : IUserInterface
    {
        public void Display(string message)
        {
            Console.WriteLine(message);
        }
    }

}
