﻿using System;
using System.Security.Principal;

namespace rid
{
    class Program
    {
        public bool IsElevated
        {
            get
            {
                return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            switch (rnd.Next(1, 12))
            {
                case 1:
                    Console.WriteLine("The operation failed successfully.");
                    break;
                case 2:
                    Console.WriteLine("You're really good at this.");
                    break;
                case 3:
                    Console.WriteLine("That's what you get for typing too fast.");
                    break;
                case 4:
                    Console.WriteLine("Hey, if you want to go back to the GUI, I won't judge.");
                    break;
                case 5:
                    Console.WriteLine("Wrong way, buddy.");
                    break;
                case 6:
                    Console.WriteLine("I gotta go, I gotta be... literally anywhere else.");
                    break;
                case 7:
                    Console.WriteLine("What, were you expecting a train or something?");
                    break;
                case 8:
                    Console.WriteLine("I'm sure you meant 'dir' but I'm just gonna let it slide.");
                    break;
                case 9:
                    Console.WriteLine("Let's roll a die! It's " + rnd.Next(1,6) + "!");
                    break;
                case 10:
                    Console.WriteLine("You're lucky I don't smack you for being a bad typer.");
                    break;
                case 11:
                    Console.WriteLine("Did you know? You can type by typing! The sky is also blue and the floor is made of floor.");
                    break;
                case 12:
                    Console.WriteLine("Congratulations! You found an ultra-rare nothing!");
                    break;
                default:
                    // nothing happens! :D
                    break;
            }
        }
    }
}