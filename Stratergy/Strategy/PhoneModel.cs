using StrategyPattern.Interfaces;

namespace StrategyPattern.Strategy
{
    public class PhoneModel
    {
        #region Instance variables

        internal IUnlockStategy _unlockPhone;
        internal IBrowseWebStrategy _browseWeb;
        internal ICalculateStrategy _calculate;

        #endregion

        internal PhoneModel(IUnlockStategy unlockPhone, IBrowseWebStrategy browseWeb, ICalculateStrategy calculate)
        {
            _unlockPhone = unlockPhone;
            _browseWeb = browseWeb;
            _calculate = calculate;
        }

        public void UnlockPhone()
        {
            _unlockPhone.UnlockPhone();
        }

        public void BrowseWeb()
        {
            _browseWeb.BrowseWeb();
        }

        public double Calculate(double firstParam, double secondParam)
        {
            return _calculate.Calculate(firstParam, secondParam);
        }
    }
}
