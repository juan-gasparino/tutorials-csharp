using System;
using System.Collections.Generic;

namespace Cubes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float d1 = 0;
                float d2 = 0;
                float xMiddle = 0;
                float yMiddle = 0;
                float zMiddle = 0;

                Console.WriteLine("Center distance cube1 l1: ");
                d1 = float.Parse(Console.ReadLine());
                Console.WriteLine("X mid point cube 1: ");
                xMiddle = float.Parse(Console.ReadLine());
                Console.WriteLine("Y mid point cube 1: ");
                yMiddle = float.Parse(Console.ReadLine());
                Console.WriteLine("Z mid point cube 1: ");
                zMiddle = float.Parse(Console.ReadLine());
                Cube cube1 = new Cube(d1, xMiddle, yMiddle, zMiddle);

                Console.WriteLine("Center distance cube 2: ");
                d2 = float.Parse(Console.ReadLine());
                Console.WriteLine("X mid point cube 2: ");
                xMiddle = float.Parse(Console.ReadLine());
                Console.WriteLine("Y mid point cube 2: ");
                yMiddle = float.Parse(Console.ReadLine());
                Console.WriteLine("Z mid point cube 2: ");
                zMiddle = float.Parse(Console.ReadLine());
                Cube cube2 = new Cube(d2, xMiddle, yMiddle, zMiddle);

                float volumeCollision = Functions.volumeCollision(d1, cube1, d2, cube2);

                if (volumeCollision != 0)
                {
                    Console.WriteLine("Intersection volume generated is: " + volumeCollision + "");
                }
                else
                {
                    Console.WriteLine("There is no collision between cubes");
                }
                Console.WriteLine("Press enter to exit");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter to exit");
                Console.ReadLine();
            }

        }
    }
}
