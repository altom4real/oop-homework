using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ocak_ödevi
{
    public class villiger : Ivilliger
    {
        public string villiger_walk(string location)
        {
            return location;
            
        }

        public string villiger_speak(string location)
        {
            return location;
        }
        public class zombie : Izombie, Ivilliger
        {
            public string villiger_speak(string location)
            {
                return location;
            }

            public string villiger_walk(string location)
            {
                return location;
            }

            public string zombie_hit(string location)
            {
                return location;
            }

            public string zombie_speak(string location)
            {
                return location;
            }

            public string zombie_walk(string location)
            {
                return location;
            }

        }
        public class skeleton : Ivilliger, Izombie, Iskeleton
        {
            public string skeleton_hit(string location)
            {
                return location;
            }

            public string skeleton_speak(string location)
            {
                return location;
            }

            public string skeleton_walk(string location)
            {
                return location;
            }

            public string villiger_speak(string location)
            {
                return location;
            }

            public string villiger_walk(string location)
            {
                return location;
            }

            public string zombie_hit(string location)
            {
                return location;
            }

            public string zombie_speak(string location)
            {
                return location;
            }

            public string zombie_walk(string location)
            {
                return location;
            }
        }
    }












}
