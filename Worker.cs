using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_13._02
{
    abstract internal class Worker
    {
        private string proff;

        public Worker() { }
        public Worker(string proff)
        {
            this.proff = proff;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Proffesional: {proff}");
        }
    }
}