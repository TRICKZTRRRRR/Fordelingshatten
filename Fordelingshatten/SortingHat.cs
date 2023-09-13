using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fordelingshatten
{
    enum Colleges { Gryffindor, Hufflepuff, Ravenclaw, Slytherin };

    class SortingHat
    {
        // Method to randomly assign a Hogwarts house
        public Colleges AssignHouse()
        {
            // Generate a random number between 0 and 3
            Random random = new Random();
            int randomNumber = random.Next(0, 4);

            // Convert the random number to a HogwartsHouse enum value
            Colleges assignedHouse = (Colleges)randomNumber;

            return assignedHouse;
        }
    }
}
