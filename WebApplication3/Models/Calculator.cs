using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Calculator
    {
        public float dola;
        
        public object result=0;

        public Calculator(float a)
        {
            this.dola = a;
            
        }
        public void chuyendolathanhdong()
        {
            result = dola * 22660;
        }
        
    }
}
