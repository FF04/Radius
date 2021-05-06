using System;
using System.IO;
///<FF>      
///
///           ███████╗███████╗
///           ██╔════╝██╔════╝
///           █████╗░░█████╗░░
///           ██╔══╝░░██╔══╝░░
///           ██║░░░░░██║░░░░░
///           ╚═╝░░░░░╚═╝░░░░░
///           
///</FF>
namespace Radius
{
    //v1.2
    class Program
    {
        public struct Point3D
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }

            public override string ToString()
            {
                return $"X: {X}, Y: {Y}, Z: {Z}";
            }
        }

        public static event EventHandler Subscribe;

        public static Subscribers subscriber = new Subscribers();

        static void Main(string[] args)
        {



            File.WriteAllText("output.txt", $""); // txt dokument leeren

            Point3D[] points = new Point3D[1000];


            Random rnd = new Random();

            for (int i = 0; i < points.Length; i++)
            {
                points[i].X = rnd.Next(-50,51);
                points[i].Y = rnd.Next(-50,51);
                points[i].Z = rnd.Next(-50,51);
            }


            Subscribe += subscriber.Sub1;
            Subscribe += subscriber.Sub2;


            InRadius(points);


   
            Console.ReadLine();
        }


        public static void InRadius(Point3D[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                if (MaxRadius10(points[i]))
                {
    
        Subscribe?.Invoke(points[i],null);


                }
            }
        }


        public static bool MaxRadius10(Point3D point)
        {
            if((Math.Sqrt(point.X) + Math.Sqrt(point.Y) + Math.Sqrt(point.Z) <= 10))
                return true;

            return false;
        }

    }
}
