using playground;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace playground
{
    public class Player
    {
        public readonly string Name;
        public Option Choice;
        public Player(string name)
        {
            Name = name;


        }

        public void PickOption()
        {
            bool ValidInput;
            do
            {
                ValidInput = true;
                Console.WriteLine("Please select rock, paper or scissor");
                switch (Console.ReadLine()?.ToLower())
                {
                    case "rock":
                    case "r":
                        Choice = Option.Rock;
                        break;
                    case "papper":
                    case "p":
                        Choice = Option.Papper;
                        break;
                    case "scissors":
                    case "s":
                        Choice = Option.Scissor;
                        break;

                }
            }
            while (!ValidInput);
            }
    }
}