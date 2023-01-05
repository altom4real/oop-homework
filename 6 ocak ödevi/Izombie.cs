using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _6_ocak_ödevi
{
    interface Izombie
    {
        string zombie_hit(string location);
        string zombie_walk(string location);
        string zombie_speak(string location);

        
    }
    interface Ivilliger
    {
        string villiger_walk(string location);
        string villiger_speak(string location);
    }
    interface Iskeleton
    {
        string skeleton_hit(string location);
        string skeleton_walk(string location);
        string skeleton_speak(string location);

    }
}
