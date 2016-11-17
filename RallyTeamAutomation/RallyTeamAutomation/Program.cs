using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            String
            startupPath = null;
            startupPath = System.IO.Directory.GetCurrentDirectory();
            startupPath = startupPath + "\\no-testing-required-it-will-work.jpg";
            Console.WriteLine("Start up path: " + startupPath);
        }
    }
}
