using StrategyPattern.InterfaceImplementation;
using StrategyPattern.Interfaces;
using StrategyPattern.Strategy;
using System;

namespace StrategyPattern
{
    class Program
    {
        #region Instance variables

        private static IUnlockStategy _faceUnlock;
        private static IUnlockStategy _fingerPrintUnlock;
         
        private static IBrowseWebStrategy _chromeBrowser;
        private static IBrowseWebStrategy _torBrowser;
         
        private static ICalculateStrategy _addition;
        private static ICalculateStrategy _division;

        #endregion

        static void Main(string[] args)
        {
            InstanciateObjects();

            PhoneModel phoneModel2_0 = new PhoneModel(_faceUnlock, _torBrowser, _division);
            PhoneModel phoneModel1_0 = new PhoneModel(_fingerPrintUnlock, _chromeBrowser, _addition);

            CallMethods(phoneModel1_0, phoneModel2_0);
        }

        private static void CallMethods(PhoneModel phoneModel1_0, PhoneModel phoneModel2_0)
        {
            phoneModel1_0.UnlockPhone();
            phoneModel2_0.UnlockPhone();
            
            phoneModel1_0.BrowseWeb();
            phoneModel2_0.BrowseWeb();
            
            Console.WriteLine($"result of Calculate method {phoneModel1_0.Calculate(90, 30)}");
            Console.WriteLine($"result of Calculate method {phoneModel2_0.Calculate(90, 30)}");
            
        }

        private static void InstanciateObjects()
        {
            _faceUnlock = new FaceUnlock();
            _fingerPrintUnlock = new FingerprintUnlock();

            _chromeBrowser = new ChromeBrowser();
            _torBrowser = new TorBrowser();

            _addition = new AdditionCalculator();
            _division = new DivisionCalculator();
        }
    }
}
