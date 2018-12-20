using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes.cs
{
    class Program
    {
        private static IEnumerable<Sweepstakes1> listOfSweepstakes;

        static void Main(string[] args)
        {
            UserInterface userinterface = new UserInterface();
            //UserInterface.MainMenu();
            List<Contestant> contestantList = new List<Contestant>() { 'Dan, Michael, Hudson, Meg' };
                foreach (Contestant person in contestantList)
            {
                foreach(Sweepstakes1 sweepstakes in listOfSweepstakes)
                {
                    sweepstakes.RegisterContestant(person);
                }
            }
            SweepstakesQueueManager queueManager = new SweepstakesQueueManager();
            SweepstakesStackManager stackManager = new SweepstakesStackManager();

            foreach (Sweepstakes1 sweepstakes in listOfSweepstakes)
            {
                queueManager.InsertSweepstakes(sweepstakes);
            }

            foreach (Sweepstakes1 sweepstakes in listOfSweepstakes)
            {
                stackManager.InsertSweepstakes(sweepstakes);
            }



        }

    }
}
