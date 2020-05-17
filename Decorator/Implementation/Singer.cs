using Decorator.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Implementation
{
    class Singer : OrchestraAbstractDecorator
    {
        public override void play()
        {
            base.play();
            Console.WriteLine("Hy I am a singer expect some melodious songs");
        }
    }

    class Clown : OrchestraAbstractDecorator
    {
        public override void play()
        {
            base.play();
            Console.WriteLine("Hy I am a clown don't you fear me");
        }
    }

    class Dancer : OrchestraAbstractDecorator
    {
        public override void play()
        {
            base.play();
            Console.WriteLine("Hy I am a dancer expect some cool moves");
        }
    }

    class Comedian : OrchestraAbstractDecorator
    {
        public override void play()
        {
            base.play();
            Console.WriteLine("Hy I am a comedian expect some rib tickling jokes");
        }
    }
}
