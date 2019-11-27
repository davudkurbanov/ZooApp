using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.lib
{
   public enum Sex { F, M }
   public class Lion
    {
        public Sex Sex { get; set; }

        public string Name { get; set; }

        public Lion(string name, Sex sex)
        {
            Name = name;
            Sex = sex;
        }
    }
}
