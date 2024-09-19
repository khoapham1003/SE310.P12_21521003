using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_ADO.NET.Business
{
    public class Animal
    {
        public virtual string MakeSound() => "...";

        public virtual int GiveMilk() => 0;

        public virtual int GiveBirth() => 0;
    }
}
