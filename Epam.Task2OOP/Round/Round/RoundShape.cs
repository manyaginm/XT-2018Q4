using System;
using System.Collections.Generic;
using System.Text;

namespace Round
{
    public abstract class RoundShape
    {

        public virtual double getLength()
        {
            return 0.0;
        }

        public virtual double getSquare()
        {
            return 0.0;
        }
    }
}
