using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes.cs
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes1> sweepstakesStack = new Stack<Sweepstakes1>();
        Stack<Sweepstakes1> tempSweepstakesStack = new Stack<Sweepstakes1>();

        
        public Sweepstakes1 GetSweepstakes1(string name)
        {
            Sweepstakes1 poppedSweepstakes;
            
            poppedSweepstakes = sweepstakesStack.Pop();
            if (poppedSweepstakes.Name == name)
            {
                IEnumerable<Sweepstakes1> tempSweepstakesStack = null;
                foreach (Sweepstakes1 sweepstakes in tempSweepstakesStack)
                {
                    sweepstakesStack.Push(poppedSweepstakes);
                }
                tempSweepstakesStack = new Stack<Sweepstakes1>();
                return poppedSweepstakes;         
            }
            else if (Sweepstakes1.Count > 0)
            {
                
                tempSweepstakesStack.Push(poppedSweepstakes);
                return GetSweepstakes1(name);           
            }
            else
            {
                
                tempSweepstakesStack.Push(poppedSweepstakes);
                foreach( Sweepstakes1 sweepstakes in tempSweepstakesStack)
                {
                    sweepstakesStack.Push(sweepstakes);
                }
                tempSweepstakesStack = new Stack<Sweepstakes1>();
                return null;
            }
        }

        public Sweepstakes1 GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        public void InsertSweepstakes (Sweepstakes1 sweepstakes)
        {

        }
    }
}
