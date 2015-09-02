using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EscaleraGame.Manager;

namespace GameRealTime.Hub
{
    public class EscaleraGameHub : Microsoft.AspNet.SignalR.Hub
    {
        private GameManager myGameManager;

        public EscaleraGameHub():this(GameManager.GetInstance())
        {
            
        }

        public EscaleraGameHub(GameManager gameManager)
        {
            this.myGameManager = gameManager;
        }
    }
}