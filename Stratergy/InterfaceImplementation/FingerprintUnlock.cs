using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.InterfaceImplementation
{
    public class FingerprintUnlock : IUnlockStategy
    {
        public void UnlockPhone()
        {
            Console.WriteLine("Phone unlocked using Fingerprint feature");
        }
    }
}
