using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject1.Repository;

namespace FinalProject1.ConsoleApp
{
    public class UserInterface
    {
        FinalProjectRepository _repo = new FinalProjectRepository();

        bool isRunning = true;

        public void Run()
        {
            _repo.SeedClientData();

            while (isRunning)
            {
                _console.PrintMainMenu();
                string userInput = _console.GetUserInput();

                UserInputPortal(userInput);
            }
        }

        private void UserInputPortal(string inputFromUser)
        {
            switch (inputFromUser)
            {
                case "1":
                    CreateClaimId();
                    break;
                case "2":
                    ClaimType();
                    break;
                case "3":
                    ClaimDescription();
                    break;
                case "4":
                    ClaimAmount();
                    break;
                case "5":
                    DateOfIncident();
                    break;
                case "6":
                    DateOfClaim();
                    break;
                case "7":
                    IsValid();
                    break;
                default:
                    break;
            }
        }

        private void CreateClaimId()
        {
            _console.EnterAnId();
            string claimId = _console.GetUserInput();
        }
    }
}