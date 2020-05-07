using StrategyPattern.Interfaces;
using System;

namespace StrategyPattern.InterfaceImplementation
{
    public class FaceUnlock : IUnlockStategy
    {
        public void UnlockPhone()
        {
            Console.WriteLine("Phone unlocked using Face unlock feature");
        }
    }
}
