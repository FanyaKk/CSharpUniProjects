using System;

namespace _11.HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int heightLath = int.Parse(Console.ReadLine());
            int tries = 0;

            bool successJump = true;
            int jumpHeight = 0;
            int jumpsCount = 0;

            for (int i = heightLath - 30; i <= heightLath; i += 5)
            {
                for (tries = 0; tries < 3; tries++)
                {
                    jumpHeight = int.Parse(Console.ReadLine());
                    jumpsCount++;
                    if (jumpHeight > i)
                    {
                        break;
                    }
                }
                if (tries == 3)
                {
                    Console.WriteLine($"Tihomir failed at {i}cm after {jumpsCount} jumps.");
                    successJump = false;
                    break;
                }
            }
            if (successJump == true)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {heightLath}cm after {jumpsCount} jumps.");
            }
        }
    }
}
