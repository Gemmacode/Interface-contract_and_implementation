using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterface
{
    internal class Decadevs:IDecadevs
    {
        string Name;
        string Squad;
        string Pod;
        string Family;

        public void Java()
        {
            Console.WriteLine("Welcome to Java Where futures are built!");
            Console.Write("Enter Your Name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter Your Pod Name: ");
            string Pod = Console.ReadLine();
            Console.WriteLine("");

        }

        public void Node()
        {
            Console.WriteLine("Welcome to Node, Where anything can be Designed for Greatness!");
            Console.Write("Enter Your Name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter Your Pod Name: ");
            string Pod = Console.ReadLine();
            Console.WriteLine("");
        }
        
        public void DotNet()
        {
            Console.WriteLine("Welcome to DotNet Where you can see Sharp!");
            Console.Write("Enter Your Name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter Your Pod Name: ");
            string Pod = Console.ReadLine();
            Console.WriteLine("");
        }
    }
}
