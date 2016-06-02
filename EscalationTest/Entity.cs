using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalationTest
{

    public class Entity
    {
        public ushort Id;
        public ushort TypeId;
        public float XPosition;
        public float YPosition;
        public float XForward;
        public float YForward;

        public override string ToString()
        {
            switch (TypeId)
            {
                case 0:
                    return "Health Pickup";
                case 1:
                    return "Chest";
                case 2:
                    return "Trap";
                case 3:
                    return "Troll";
                case 4:
                    return "Imp";
                case 5:
                    return "Ogre";
                default:
                    return "";
            }
        }
    }
}
