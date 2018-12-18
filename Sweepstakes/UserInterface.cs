using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes.cs
{
    public class UserInterface
    {
        //Sweepstakes sweepstakes = new Sweepstakes();
        Contestant contestant = new Contestant();
        public int registrationNumber { get; set; }

        public void MainMenu()
        {
            StartSweepstakes();
            MarketingFirm marketingFirm = new MarketingFirm();
            marketingFirm.MarketingFirmMenu();
        }

        public void StartSweepstakes()
        {
            Console.Clear();
            Console.WriteLine("Welcome -Enter company name here --Marketing Firm.\n");
        }
        public string GetContestantInformation(string thisCase)
        {
            switch (thisCase)
            {
                case "firstname":
                    Console.WriteLine("Enter contestant's first name:");
                    return Console.ReadLine();
                case "lastname":
                    Console.WriteLine("Enter contestant's last name:");
                    return Console.ReadLine();
                case "emailaddress":
                    Console.WriteLine("Enter contestant's email address:");
                    return Console.ReadLine();
                case "registrationnumber":
                    Console.WriteLine("Enter contestant's registration number:");
                    return Console.ReadLine();
                default:
                    return "Invalid Information";
            }

             bool CheckSubscribeStatus()
            {
                Console.WriteLine("Do you want to know who won the Sweepstakes? Yes or No?");
                string thisInput = Console.ReadLine().ToLower();
                switch (thisInput)
                {
                    case "yes":
                        return true;
                    case "no":
                        return false;
                    default:
                        Console.WriteLine("Invalid Input entered. Please enter valid response.");
                        return CheckSubscribeStatus();
                }         
            }
        }

        public void PrintContestantInfo()
        {
            Console.WriteLine("\n Contestant Info --\n");
        }

        public string GetSweepstakesChoice()
        {
            Console.WriteLine("Please choose a sweepstakes for your Marketing Firm. Your options are Queue or Stack.");
            return Console.ReadLine().ToLower();
        }

        public static string GetSweepstakesNameSelection()
        {
            Console.WriteLine("Please enter the name of the sweepstakes:");
            return Console.ReadLine();
        }

        public static void DisplaySelectedSweepstakes(string sweepstakesName)
        {
            Console.WriteLine("You have selected:" + sweepstakesName);
        }
        public string DisplayContestantInformation(string SweepstakesName, string firstName, string lastName, string emailAddress, int registrationNumber)
        {
            Console.WriteLine("First name: " + firstName);     
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine("Email address:" + emailAddress);
            Console.WriteLine("Registration Number:" + registrationNumber);
            return Console.ReadLine().ToLower();
        }

        internal static bool CheckIfSubscribe()
        {
            throw new NotImplementedException();
        }

        public static string GetStringFromConsole()
        {
            return Console.ReadLine();
        }

        public static string GetEmailFromConsole()
        {
            return Console.ReadLine();
        }

        public static void DisplayWinner(string sweepStakesName, Contestant contestant)
        {
            Console.WriteLine("Congratulations! You won the " + sweepStakesName + "sweeptakes." );
            Console.WriteLine("Contestant Winner!");
            Console.WriteLine("Frist name:" + contestant.FirstName);
            Console.WriteLine("Last name:" + contestant.LastName);
            Console.WriteLine("Email:" + contestant.EmailAddress);
            Console.WriteLine("Contestant registration number:" + contestant.RegistrationNumber);

        }

       
    }
}
