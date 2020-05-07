﻿using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.InterfaceImplementation
{
    public class ChromeBrowser : IBrowseWebStrategy
    {
        public void BrowseWeb()
        {
            Console.WriteLine("Web browsed using Chrome browser");
        }
    }
}
