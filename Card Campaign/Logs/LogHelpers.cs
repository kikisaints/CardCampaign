using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Campaign.Logs
{
    class LogHelpers
    {
        public int GetStatModifier(int stat)
        {
            float fmodifier = (stat - 10) / 2;
            fmodifier = (float)Math.Floor(fmodifier);
            
            return (int)fmodifier;
        }
    } 
}
