using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace csy
{
    public class Student : IStudent
    {
        private string _stuCode;
        private string _stuName;

        public string StuCode 
        { 
            get
            {
                return _stuCode;
            }
            set
            {
                _stuCode = value;
            }
        }
        public string StuName 
        {
            get
            {
                return _stuName;
            }
            set
            {
                _stuName = value;
            }
        }

        public string GetInfo()
        {
            return _stuCode + "\t" + _stuName;
        }
    }
}