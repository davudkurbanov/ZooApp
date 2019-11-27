using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.lib
{
    public class Zoo
    {
        public decimal EntranceFee { get; set; } = 50.0M;

        public Zoo(decimal entranceFee)
        {
            EntranceFee = entranceFee;
        }
    }
}
