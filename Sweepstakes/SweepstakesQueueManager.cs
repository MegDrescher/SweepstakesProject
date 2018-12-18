using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes.cs
{           // queue data structure
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes1> sweepstakesQueue = new Queue<Sweepstakes1>();
        Queue<Sweepstakes1> tempSweepstakesQueue = new Queue<Sweepstakes1>();
        public Sweepstakes1 GetSweepstakes(string name)
        {
            Sweepstakes1 dequeuedSweepstakes;
            dequeuedSweepstakes = sweepstakesQueue.Dequeue();
            if (dequeuedSweepstakes.Name == name)
            {
                foreach(Sweepstakes1 sweepstakes in tempSweepstakesQueue)
                {
                    sweepstakesQueue.Enqueue(sweepstakes);
                }
                tempSweepstakesQueue = new Queue<Sweepstakes1>();
                return dequeuedSweepstakes;         
            }
            else if (Sweepstakes1.Count > 0)
            {
                tempSweepstakesQueue.Enqueue(dequeuedSweepstakes);
                return GetSweepstakes(name);
            }
            else
            {
                tempSweepstakesQueue.Enqueue(dequeuedSweepstakes);
                foreach (Sweepstakes1 sweepstakes in tempSweepstakesQueue)
                {
                    sweepstakesQueue.Enqueue(sweepstakes);
                }
                tempSweepstakesQueue = new Queue<Sweepstakes1>();
                return null;
            }
        }

        public void DisplaySweepstakes()
        {        
            foreach(Sweepstakes1 sweepstakes in sweepstakesQueue)
            {
                
                Console.WriteLine(sweepstakes );
            }
        }

        public void InsertSweepstakes (Sweepstakes1 sweepstakes)
        {
            sweepstakesQueue.Enqueue(sweepstakes);
        }

        public Sweepstakes1 GetSweepstakes()
        {
            throw new NotImplementedException();
        }
    }
}
