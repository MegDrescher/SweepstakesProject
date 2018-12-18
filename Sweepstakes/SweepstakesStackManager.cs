using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes.cs
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> sweepstakesStack = new Stack<Sweepstakes>();
        Stack<Sweepstakes> tempSweepstakesStack = new Stack<Sweepstakes>();

        
        public Sweepstakes GetSweepstakes(string name)
        {
            Sweepstakes poppedSweepstakes;
            
            poppedSweepstakes = sweepstakesStack.Pop();
            if (poppedSweepstakes.Name == name)
            {
                IEnumerable<Sweepstakes> tempSweepstakesStack = null;
                foreach (Sweepstakes sweepstakes in tempSweepstakesStack)
                {
                    sweepstakesStack.Push(poppedSweepstakes);
                }
                tempSweepstakesStack = new Stack<Sweepstakes>();
                return poppedSweepstakes;         
            }
            else if (Sweepstakes.Count > 0)
            {
                
                tempSweepstakesStack.Push(poppedSweepstakes);
                return GetSweepstakes(name);           
            }
            else
            {
                
                tempSweepstakesStack.Push(poppedSweepstakes);
                foreach( Sweepstakes sweepstakes in tempSweepstakesStack)
                {
                    sweepstakesStack.Push(sweepstakes);
                }
                tempSweepstakesStack = new Stack<Sweepstakes>();
                return null;
            }
        }

        public Sweepstakes GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        public void InsertSweepstakes (Sweepstakes sweepstakes)
        {

        }
    }
}
