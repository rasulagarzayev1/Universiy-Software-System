using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Final.Model
{
    public class Comboitem
    {
        public int Value { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
