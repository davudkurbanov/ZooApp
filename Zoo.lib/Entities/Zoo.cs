using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.lib
{
    public class PublicZoo
    {
        public decimal EntranceFee { get; set; } = 50.0M;

        public LionCage LionCage { get; set; }

        public PublicZoo(decimal entranceFee)
        {
            EntranceFee = entranceFee;
            LionCage = new LionCage();
        }
    }
}
