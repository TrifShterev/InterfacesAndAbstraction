using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : ICall
    { private string number;
        public StationaryPhone()
        {

        }
        public StationaryPhone(string number)
            :this()
        {
            Number = number;
        }
        public string Number
        {
            get { return number; }
            set
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

        public string Calling()
        {
            return $"Dialing... {Number}";
        }
    }
}
