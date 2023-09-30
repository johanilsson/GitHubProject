using RockPaperScissors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RockPaperScissors
{
    public class Player
    {
        public readonly string Name;
        public Option = Choice;
        public Player(string name)
        {
            Name = name;


        }



    }

    void PickOption()
    {
        bool ValidInput;
        do
        {
            ValidInput = true;
            Console.WriteLine("Please seöect rpck, paper or scissor");
            switch (Console.ReadLine()?.ToLower())
            {
                case "rock":
                case "r":
                    Choice = Option.rock;
                case "papper":
                    Choice = Option.papper;
                case "scissor":
                    Choice = Option.scissors;

            }
        }


    }
}
