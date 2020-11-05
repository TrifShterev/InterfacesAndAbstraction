using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICall, IBrowse
    {
        private string number;
        private string site;
        public Smartphone()
        {

        }
        public Smartphone(string number)
            :this()
        {
            Number = number;
        }
        public Smartphone( string number,string site)
            :this(number)
        {
            
            Site = site;
        }
        public string Number { get { return number; } set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsLetter(value[i]))
                    {
                        throw new ArgumentException("Invalid number!");

                    }
                }
                number = value;
            }
        }
        public string Site { get { return site; } set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i]))
                    {
                        throw new ArgumentException("Invalid URL!");
                       
                    }
                }
                site = value;
            } }
        public string Browsing()
        {
            return $"Browsing: {Site}!";

        }
        public string Calling()
        {
            return $"Calling... {Number}";
        }
    }
}
