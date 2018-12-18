using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes.cs
{       
    interface ISweepstakesManager
    {
        void InsertSweepstakes(Sweepstakes1 sweepstakes);


        Sweepstakes1 GetSweepstakes();
       
            

    }
}
