using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace csy
{
    public class CardPage : ICardPage
    {
        private string _code;
        private string _name;
        private string _balance;

        public string Code 
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        public string Name 
        { 
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }
    }
}