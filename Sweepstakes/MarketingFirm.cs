using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes.cs
{
    class MarketingFirm
    {
        public ISweepstakesManager sweepstakesManager;
        Sweepstakes1 selectedSweepstakes;
        string sweepstakesName;
        string marketingFirmName;
        int action;

        public MarketingFirm()
        {
        }

        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            marketingFirmName = "";
            this.sweepstakesManager = sweepstakesManager;
        }

        internal void MarketingFirmMenu()
        {
            throw new NotImplementedException();
        }

        public void InsertSweepstakes(Sweepstakes1 sweepstakes)
        {
            sweepstakesManager.InsertSweepstakes(sweepstakes);
        }
        
        Sweepstakes1 GetSweepstakes()
        {
            return sweepstakesManager.GetSweepstakes();
        }
    }
}
