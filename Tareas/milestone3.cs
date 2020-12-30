using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class milestone3
    {
        public void Variables()
        {
            int[] Lista = {1,2,3,4,5,6,7,8,9,10};

            for(int i = Lista.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(Lista[i]);
            }
        }
    }
}
