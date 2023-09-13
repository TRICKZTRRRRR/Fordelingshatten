using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fordelingshatten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hogwarts!");

            // Instantiate the SortingHat
            SortingHat sortingHat = new SortingHat();

            // Call the AssignHouse method to determine the assigned house
            Colleges assignedHouse = sortingHat.AssignHouse();

            // Display the assigned house to the user
            Console.WriteLine("The Sorting Hat has chosen your house:");

            switch (assignedHouse)
            {
                case Colleges.Gryffindor:
                    Console.WriteLine("You belong to Gryffindor - for the brave and strong!");
                    break;
                case Colleges.Hufflepuff:
                    Console.WriteLine("You belong to Hufflepuff - for the loyal and kind-hearted!");
                    break;
                case Colleges.Ravenclaw:
                    Console.WriteLine("You belong to Ravenclaw - for the curious and intelligent!");
                    break;
                case Colleges.Slytherin:
                    Console.WriteLine("You belong to Slytherin - for the cunning and ambitious!");
                    break;
                default:
                    Console.WriteLine("The Sorting Hat couldn't decide!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
