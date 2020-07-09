using System;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            var outlander = new Outlander(36);
            outlander.steer(45);
            outlander.accelerate(30);
            outlander.accelerate(20);
        }
    }
}
