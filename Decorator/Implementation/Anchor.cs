using Decorator.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Implementation
{
    class Anchor : OrchestraAbstractDecorator
    {
        public override void play()
        {
            base.play();
            Console.WriteLine("Hy I am an anchor expect some witty remarks");
        }
    }
}
