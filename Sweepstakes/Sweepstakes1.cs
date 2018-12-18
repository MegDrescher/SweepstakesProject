using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes.cs
{

        public class Sweepstakes1
        {
            public string name;
            int contestantCount;
            Dictionary<int, Contestant> contestants;
            Random random;
            internal static int Count;

            public string Name
            {
                get
                {
                    return name;
                }
            }

            public Sweepstakes1(string name)
            {
                int contestantCount = 0;
                Dictionary<int, Contestant> contestants;
                random = new Random();
            }
            public void RegisterContestant(Contestant contestant)
            {
                contestants.Add(contestant.RegistrationNumber, contestant);
            }
            public string PickWinner()
            {   //Dictionary<string, string>  = new Dictionary<string, string>();
                Contestant winner = contestants[random.Next(0, contestantCount)];
                PrintContestantInfo(winner);
                string winnerEmail = winner.EmailAddress;
                // Notify(winnerEmailAddress);
                return winner.FirstName;
            }

            public void PrintContestantInfo(Contestant Contestant)
            {
                Console.WriteLine(Contestant.ToString());

            }
            void NotifyConstestant(string winnerEmail)
            {
                foreach (KeyValuePair<int, Contestant> contestant in contestants)
                {
                    if (contestant.Value.EmailAddress != winnerEmail && contestant.Value.DidSubscribe == true)
                    {
                        UserInterface.DisplayWinner(name, contestant.Value);
                    }
                    else if (contestant.Value.EmailAddress == winnerEmail)
                    {
                        UserInterface.DisplayWinner(name, contestant.Value);
                        SendEmail(winnerEmail, contestant.Value);
                    }
                }
            }
            public void SendEmail(string emailAddress, Contestant contestant)
            {

            }
        }
    }


