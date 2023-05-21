using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6.Observers
{
    internal interface CObject
    {
        void notifyEveryone();
        void AddObserver(CObserver obj);
    }
}
