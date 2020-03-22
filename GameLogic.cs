using System;
using System.Collections.Generic;
using System.Text;

namespace gameServer
{
    class GameLogic 
    {
        public static void Update()
        {
            ThreadManager.UpdateMain();
        }
    }
}
