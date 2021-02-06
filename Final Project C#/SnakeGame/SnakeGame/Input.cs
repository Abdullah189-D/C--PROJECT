using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Windows.Forms;

namespace SnakeGame
{
    class Input
    {
        private static Hashtable KeyTable = new Hashtable();
        
        public static bool KeyPress(Keys key)
        {
            
            if (KeyTable[key] == null)
            {
                
                return false;
            }
            
            return (bool)KeyTable[key];
        }
        public static void changeState(Keys key, bool state)
        {
            

            KeyTable[key] = state;
        }

    }
}

