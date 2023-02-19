using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_13._02
{
    internal class Engineer : Worker
    {
        public Engineer() { }
        public Engineer(string proff) : base(proff) { }

        public override void Print()
        {
            base.Print();
        }
    }
}
