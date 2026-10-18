using System;
using System.Collections.Generic;
using System.Text;

namespace FractionApp
{
    public  interface ICalculatable
    {
        object Add( object other);
        object Subtract(object other);
    }
}
