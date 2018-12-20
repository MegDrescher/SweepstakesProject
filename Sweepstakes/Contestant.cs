using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes.cs
{
    public class Contestant : ISubscriber
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        Contestant contestant;
        bool didSubscribe;
        public int RegistrationNUmber { get; set; }
        

        public void Subscribe()
        {

        }
        public bool DidSubscribe
        {
            get
            {
                return didSubscribe;
            }
        }

        public int RegistrationNumber { get; set; }

        public Contestant()
        {
            GetContestantFromConsole();
        }

        public void GetContestantFromConsole()
        {
            Console.WriteLine("First name:");
            FirstName = UserInterface.GetStringFromConsole();
            Console.WriteLine("Last name:");
            LastName = UserInterface.GetStringFromConsole();
            EmailAddress = UserInterface.GetEmailFromConsole();
        }

        public Contestant(string firstName, string lastName, string emailAddress, int registrationNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            RegistrationNUmber = registrationNumber;
            didSubscribe = UserInterface.CheckIfSubscribe();
        }

        public override string ToString()
        {
            return $"{FirstName}{LastName}\n{EmailAddress}"; 
        }
    }
}


