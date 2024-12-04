using System;

namespace SimonJochum.Week07.SupermarketOOP
{
    public class Staff
    {
        private string _name;
        private string _staffId;
        private string _role;
        private bool _check;

        public Staff(string name, string staffId)
        {
            _name = name;
            _staffId = staffId;
        }

        public bool StartWork()
        {
            return _check = true;
        }

        public bool EndWork()
        {
            return _check = false;
        }

        public bool WorkAtCheckout()
        {
            if (_check == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}