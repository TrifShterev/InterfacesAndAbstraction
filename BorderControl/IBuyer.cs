using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public interface IBuyer 
    {
      
        public int Food { get { return Food; } set { Food = 0; } }

        public void BuyFood();
    }
}
