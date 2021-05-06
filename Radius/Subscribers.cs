using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radius
{
    class Subscribers
    {



        // A
        public void Sub1(object? sender, EventArgs e)
        {
            var point = (Program.Point3D)sender;
            Console.WriteLine(point);
        }
        public void Sub2(object? sender, EventArgs e)
        {
            File.AppendAllText("output.txt", $"{(Program.Point3D)sender}\n");
        }



    }
}
