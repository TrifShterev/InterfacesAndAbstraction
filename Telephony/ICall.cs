using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
  public  interface ICall
    {
        
        public string Number { get; set; }

        public string Calling();
    }
}
