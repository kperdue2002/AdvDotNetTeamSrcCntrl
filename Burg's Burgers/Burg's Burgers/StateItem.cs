using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burg_s_Burgers
{
    public class StateItem
    {
        public string StateName { get; set; }
        public string StateAbbreviation { get; set; }

        public override string ToString()
        {
            return StateName;
        }
    }
}
