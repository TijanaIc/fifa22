using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifa22
{
    public delegate void PrintMessage(string message);

    public class DelegatePlayground
    {        
        public void Run(PrintMessage d)
        {
            d("Tijana");
        }
    }
}
