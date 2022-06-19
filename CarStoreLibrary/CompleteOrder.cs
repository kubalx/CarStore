using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace CarStoreLibrary
{
    public class CompleteOrder : Store
    {
        private string _email;
        public CompleteOrder(string email)
        {
            _email = email;
        }
        override public string ToString()
        {
            return _email;
        }
    }
}
