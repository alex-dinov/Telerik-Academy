using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistant
{
    class Firm
    {
        public string Name { get; set; }

        public Firm()
        {
        }

        public Firm(string firm)
        {
            this.Name = firm;
        }
    }
}
