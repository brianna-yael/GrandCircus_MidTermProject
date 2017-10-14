using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    class WaterSource
    {
        public string name { get; }
        public int supply { get; }

        public WaterSource(string name, int supply)
        {
            this.name = name;
            this.supply = supply;
        }
    }
}
