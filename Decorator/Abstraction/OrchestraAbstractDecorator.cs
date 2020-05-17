using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Abstraction
{
    abstract class OrchestraAbstractDecorator : IOrchestra
    {
        public IOrchestra orchestra { get; set; }
        public virtual void play()
        {
            if (orchestra != null)
                orchestra.play();
        }
    }
}
