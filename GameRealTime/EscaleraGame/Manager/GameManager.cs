using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscaleraGame.Manager
{
    public class GameManager
    {
        private static GameManager GameManagerInstance { get; set; }

        static GameManager()
        {
            GameManagerInstance = new GameManager();
        }

        private GameManager()
        {

        }

        public static GameManager GetInstance()
        {
            return GameManagerInstance;
        }
    }
}
