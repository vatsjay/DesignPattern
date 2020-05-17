using Decorator.Abstraction;
using Decorator.Implementation;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            OrchestraAbstractDecorator anchor = new Anchor();
            OrchestraAbstractDecorator clown = new Clown();
            OrchestraAbstractDecorator comedian = new Comedian();
            OrchestraAbstractDecorator dancer = new Dancer();
            OrchestraAbstractDecorator singer = new Singer();


            while (true)
            {
                Console.WriteLine("Which package you want write \n F for free \n P for premium \n G for gold");
                var input = Console.ReadLine().ToCharArray()[0];
                Console.WriteLine(input.ToString());
                switch (input)
                {
                    case 'F':
                    case 'f':
                        Console.WriteLine("In free package you get Anchor and singer :)");
                        singer.orchestra = anchor;
                        singer.play();
                        break;

                    case 'P':
                    case 'p':
                        Console.WriteLine("In premium package you get Anchor, singer, dancer and comedian:)");
                        comedian.orchestra = dancer;
                        dancer.orchestra = singer;
                        singer.orchestra = anchor;
                        comedian.play();
                        break;

                    case 'G':
                    case 'g':
                        Console.WriteLine("In premium package you get Anchor, singer, dancer, comedian and clown:)");
                        clown.orchestra = comedian;
                        comedian.orchestra = dancer;
                        dancer.orchestra = singer;
                        singer.orchestra = anchor;
                        clown.play();
                        break;
                    default:
                        Console.WriteLine("whatever you selected you get an anchor : ");
                        anchor.play();
                        break;
                }
            }
        }
    }
}
